using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;

namespace ProjectPlanner4
{
    public enum TicketWindowMode {Modify, Create};
    public enum LoadState {Open, Closed, Both };

    public partial class FormMain : Form
    {
        // Forms
        public FormTicket frmTicket = null;
        public FormSettings frmCategory = null;

        // Selected ticket
        public Ticket selectedTicket = null;
        public bool isOnOpenList = false;
        public bool isWorking = false;

        // Other
        private int totalProjectTime = 0;

        // Lists
        public List<Ticket> openList = new List<Ticket>();
        public List<Ticket> closedList = new List<Ticket>();

        #region Forms

        public FormMain()
        {
            InitializeComponent();

            // Setup Categories
            Functions.categories.Add(new Category("All", 0));
            Functions.categories.Add(new Category("Unassigned", 1));

            // Load Combo Boxes data
            LoadComboAndViewData(LoadState.Both, Functions.categories[0], 0);

            // Hide the buttonFinishTicket
            buttonFinishTicket.Hide();
        }

        // Open ticket window
        private void OpenTicketWindow(TicketWindowMode mode, Ticket ticket)
        {
            if (frmTicket == null)
            {
                // Open Window
                frmTicket = new FormTicket(this, mode, ticket);
                frmTicket.Show();
            }
        }

        // Open category window
        private void OpenCategoryWindow()
        {
            if (frmCategory == null)
            {
                // Open window
                frmCategory = new FormSettings(this);
                frmCategory.Show();
            }
        }

        #endregion

        #region Buttons

        // Button Modify current ticket
        private void buttonCurrentTicketModify_Click(object sender, EventArgs e)
        {
            // If a ticket is selected
            if (selectedTicket != null)
            {
                // Opens the modify ticket
                OpenTicketWindow(TicketWindowMode.Modify, selectedTicket);

                // Remove selected ticket from list
                openList.Remove(selectedTicket);
                // Remove selected ticket from list
                closedList.Remove(selectedTicket);

                // Unload graphics
                UnloadOnUnselectedData();

                // Set selected ticket as null, so we cant modify it again.
                selectedTicket = null;


                if (isWorking)
                {
                    // Hide the finish button
                    buttonFinishTicket.Hide();

                    // Set the text for buttonStartStop
                    buttonStartStopCurrentTicket.Text = "Start";

                    // Stop the timer
                    timer.Stop();

                    // Set the isWorking state
                    isWorking = false;
                }
            }
            else
            {
                MessageBox.Show("No item present!");
            }
        }

        // Button Start/Stop current ticket
        private void buttonStartStopCurrentTicket_Click(object sender, EventArgs e)
        {
            // If there is a selected ticket
            if(selectedTicket != null)
            {
                // If the user is not working on the ticket
                if (!isWorking)
                {
                    // Show the buttonFinishTicket
                    buttonFinishTicket.Show();

                    // Set the text for buttonStartStop
                    buttonStartStopCurrentTicket.Text = "Pause";

                    // Start the timer
                    timer.Start();

                    // Set the isWorking state
                    isWorking = true;
                }
                else
                {
                    // Hide the finish button
                    buttonFinishTicket.Hide();

                    // Set the text for buttonStartStop
                    buttonStartStopCurrentTicket.Text = "Start";

                    // Stop the timer
                    timer.Stop();

                    // Set the isWorking state
                    isWorking = false;
                }
            }
        }

        // Button FinishTicket
        private void buttonFinishTicket_Click(object sender, EventArgs e)
        {
            // Save subtasks
            SaveSubTasks();

            // Remove selected ticket from list
            openList.Remove(selectedTicket);

            // Remove selected ticket from list
            closedList.Add(selectedTicket);

            // Unload graphics
            UnloadOnUnselectedData();

            // Load graphics 
            LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);

            // Set selected ticket as null, so we cant modify it again.
            selectedTicket = null;

            // Hide the finish button
            buttonFinishTicket.Hide();

            // Set the text for buttonStartStop
            buttonStartStopCurrentTicket.Text = "Start";

            // Stop the timer
            timer.Stop();

            // Set the isWorking state
            isWorking = false;
        }

        #endregion

        #region ToolStrip

        // Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadDialog = new OpenFileDialog();
            loadDialog.Filter = "XML Files | *.xml";

            if (loadDialog.ShowDialog() == DialogResult.OK)
            {
                SaveData returnData = Functions.LoadData(loadDialog.FileName);

                // LOAD ALL DATA TO LISTS
                openList = returnData.openList;
                closedList = returnData.closedList;
                totalProjectTime = returnData.globalTimer;
                labelProjectTimeTotal.Text ="Total Time: " + TimeSpan.FromSeconds(totalProjectTime);
                Functions.categories = returnData.categoriesList;
                LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
            }
        }

        // Save File
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML Files | *.xml";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the data
                Functions.SaveData(new SaveData(totalProjectTime, openList, closedList, Functions.categories), saveDialog.FileName);
            }
        }

        // Create ticket
        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SHORTCUTS ARE DIRECT DUPLICATES!

            if (!isWorking)
            {
                // Open the ticket window
                OpenTicketWindow(TicketWindowMode.Create, null);
            }
        }

        // Open Settings
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SHORTCUTS ARE DIRECT DUPLICATES!

            // Open the category window
            OpenCategoryWindow();
        }

        // New project
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning, unsaved data might be lost!", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        // View Documentation
        private void viewDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocumentation documentation = new FormDocumentation();
            documentation.Show();
        }

        // Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning, unsaved data might be lost!", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        #endregion

        #region ComboBox

        // On Selection changed ComboBox OpenList
        private void comboBoxOpenList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category selectedCategory = new Category(comboBoxOpenList.SelectedItem.ToString(), -1);
            LoadComboAndViewData(LoadState.Open, selectedCategory, comboBoxOpenList.SelectedIndex);
        }

        // On Selection changed ComboBox OpenList
        private void listBoxClosedTickets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category selectedCategory = new Category(comboBoxClosedList.SelectedItem.ToString(), -1);
            LoadComboAndViewData(LoadState.Closed, selectedCategory, comboBoxClosedList.SelectedIndex);
        }

        #endregion

        #region Public Methods

        // Load comboboxes data and viewLists
        public void LoadComboAndViewData(LoadState state, Category category, int selectIndex)
        {
            if (state == LoadState.Open || state == LoadState.Both)
            {
                // Clear data
                comboBoxOpenList.Items.Clear();
                listBoxOpenTickets.Items.Clear();

                // Load ComboBox
                Functions.LoadCategoryDataTo(comboBoxOpenList, selectIndex);

                // Show selection based on category
                Functions.ShowBasedSelection(category, openList, listBoxOpenTickets);
            }

            if (state == LoadState.Closed || state == LoadState.Both)
            {
                // Closed data
                comboBoxClosedList.Items.Clear();
                listBoxClosedTickets.Items.Clear();

                // Load ComboBox
                Functions.LoadCategoryDataTo(comboBoxClosedList, selectIndex);

                // Show selection based on category
                Functions.ShowBasedSelection(category, closedList, listBoxClosedTickets);
            }

            // Update ticket count
            UpdateTicketCount();
        }

        #endregion

        #region Private Methods

        // Loads selected item data from a list
        private void LoadSelectedItemData(LoadState loadState)
        {
            // Setup for both closed and open list.
            List<Ticket> ticketList = null;
            ListBox listBox = null;

            if (loadState == LoadState.Open)
            {
                ticketList = openList;
                listBox = listBoxOpenTickets;
                isOnOpenList = true;

                // Enable button and checkBoxList
                checkedListBoxCurrentTicketSubtasks.Enabled = true;
                buttonStartStopCurrentTicket.Enabled = true;
            }
            else
            {
                ticketList = closedList;
                listBox = listBoxClosedTickets;
                isOnOpenList = false;

                // Enable button and checkBoxList
                checkedListBoxCurrentTicketSubtasks.Enabled = false;
                buttonStartStopCurrentTicket.Enabled = false;
            }

            // If the user is not working on another ticket
            if (!isWorking && listBox.SelectedItems.Count != 0)
            {
                // Get selected name find from list
                string selectedName = listBox.SelectedItem.ToString();

                // Clear subTask display box before use.
                checkedListBoxCurrentTicketSubtasks.Items.Clear();

                // Setup empty find ticket
                Ticket selectedTicket = null;

                // Find the correct ticket
                foreach (Ticket t in ticketList)
                {
                    if (t.displayName == selectedName)
                    {
                        selectedTicket = t;
                    }
                }

                // Set the selected ticket 
                this.selectedTicket = selectedTicket;

                // Set Data View
                textBoxCurrentTicketName.Text = selectedTicket.displayName;
                richTextCurrentTicket.Text = selectedTicket.description;
                labelCurrentTicketTimer.Text = "Time Spent: " + TimeSpan.FromSeconds(selectedTicket.timeSpent);

                // Fill subtask list
                foreach (SubTask s in selectedTicket.subTasks)
                {
                    // Fill with new items
                    checkedListBoxCurrentTicketSubtasks.Items.Add(s.name, s.checkedState);
                }
            }

            // Set the ticket counts
            UpdateTicketCount();
        }

        // Unloads item data from a list
        private void UnloadOnUnselectedData()
        {
            if(selectedTicket != null)
            {
                // Name
                textBoxCurrentTicketName.Text = "";

                // Description
                richTextCurrentTicket.Text = "";

                // Listbox
                checkedListBoxCurrentTicketSubtasks.Items.Clear();

                // Timer
                labelCurrentTicketTimer.Text = "Time Spent: 00:00:00";

                // Save subtasks out
                SaveSubTasks();
            }
        }

        // Saves out subtasks
        private void SaveSubTasks()
        {
            // Save subtasks
            for (int i = 0; i < checkedListBoxCurrentTicketSubtasks.Items.Count; i++)
            {
                selectedTicket.subTasks[i].checkedState = checkedListBoxCurrentTicketSubtasks.GetItemCheckState(i);
            }
        }

        private void UpdateTicketCount()
        {
            labelOpenTicketsAmount.Text = "Open Tickets: " + openList.Count;
            labelClosedTicketsAmount.Text = "Closed Tickets: " + closedList.Count + "/" + (openList.Count + closedList.Count);
        }

        #endregion

        #region ListBox

        // Inspect item on open list
        private void listBoxOpenTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save subtasks
            SaveSubTasks();

            // Load selected item data from openList
            LoadSelectedItemData(LoadState.Open);
            listBoxOpenTickets.ClearSelected();
        }

        // Inspect item on closed list
        private void listBoxClosedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save subtasks
            SaveSubTasks();

            // Load selected item data from openList
            LoadSelectedItemData(LoadState.Closed);
            listBoxClosedTickets.ClearSelected();
        }

        #endregion


        // Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // Update timers
            selectedTicket.timeSpent += 1;
            totalProjectTime += 1;

            // Convert seconds to hours:minutes:seconds
            TimeSpan resultTicket = TimeSpan.FromSeconds(selectedTicket.timeSpent);
            TimeSpan resultGlobal = TimeSpan.FromSeconds(totalProjectTime);

            // Set labels
            labelCurrentTicketTimer.Text = "Time Spent: " + resultTicket;
            labelProjectTimeTotal.Text = "Total Time: " + resultGlobal;
        }

        // Shortcuts
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Create Ticket
            if(e.Control && e.KeyCode == Keys.T)
            {
                if (!isWorking)
                {
                    // Open the ticket window
                    OpenTicketWindow(TicketWindowMode.Create, null);
                }
            }

            // Create category
            if (e.Control && e.KeyCode == Keys.C)
            {
                // Open the category window
                OpenCategoryWindow();
            }

            // Save File
            if(e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XML Files | *.xml";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the data
                    Functions.SaveData(new SaveData(totalProjectTime, openList, closedList, Functions.categories), saveDialog.FileName);
                }
            }

            // Open File
            if (e.Control && e.KeyCode == Keys.A)
            {
                OpenFileDialog loadDialog = new OpenFileDialog();
                loadDialog.Filter = "XML Files | *.xml";

                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveData returnData = Functions.LoadData(loadDialog.FileName);

                    // LOAD ALL DATA TO LISTS
                    openList = returnData.openList;
                    closedList = returnData.closedList;
                    totalProjectTime = returnData.globalTimer;
                    labelProjectTimeTotal.Text = "Total Time: " + TimeSpan.FromSeconds(totalProjectTime);
                    Functions.categories = returnData.categoriesList;
                    LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
                }
            }
        }
    }
}
