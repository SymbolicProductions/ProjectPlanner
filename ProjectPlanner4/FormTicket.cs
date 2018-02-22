using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPlanner4
{
    public partial class FormTicket : Form
    {
        public FormSubTask frmSubTask = null;

        private TicketWindowMode mode = TicketWindowMode.Create;
        private Ticket ticket;
        private FormMain frmMain = null;

        #region Form

        public FormTicket(FormMain frmMain, TicketWindowMode mode, Ticket ticket)
        {
            InitializeComponent();

            // Setup references
            this.frmMain = frmMain;

            // Set the mode states
            if(mode == TicketWindowMode.Create)
            {
                labelTicketTimeSpent.Hide();
                buttonTicketDelete.Hide();
                
                // Load default data
                Functions.LoadCategoryDataTo(checkListBoxTicketCategory, true);

                // Set a name for ticket at start
                textBoxTicketName.Text = "Ticket " + (frmMain.openList.Count + frmMain.closedList.Count);
            }
            else
            {
                // Setup variables
                this.mode = mode;
                this.ticket = ticket;

                // Load ticket data
                textBoxTicketName.Text = ticket.name;
                richTextTicket.Text = ticket.description;

                // Timer
                labelTicketTimeSpent.Show();
                labelTicketTimeSpent.Text = "Time Spent: " + ticket.timeSpent;

                // Fill subtask list
                foreach (SubTask s in ticket.subTasks)
                {
                    // Fill with new items
                    checkListBoxSubTasks.Items.Add(s.name, s.checkedState);
                }

                // Load default data
                Functions.LoadCategoryDataTo(checkListBoxTicketCategory, false);

                // Setup IndexNumber
                int indexNumber = -1;

                // Find the indexNumber within categories
                for(int i = 0; i < Functions.categories.Count; i++)
                {
                    // If the names match
                    if(Functions.categories[i].name == ticket.category.name)
                    {
                        indexNumber = i - 1;
                    }
                }

                // Set item as checked
                checkListBoxTicketCategory.SetItemCheckState(indexNumber, CheckState.Checked);

                // Set the buttonCreate TEXT
                buttonTicketCreate.Text = "Save";
            }
        }

        // On clicking outside of any controls
        private void FormTicket_MouseClick(object sender, MouseEventArgs e)
        {
            // Do the click check for subtasks list
            int indexSubTask = checkListBoxSubTasks.IndexFromPoint(e.Location);

            // If no item selected
            if (indexSubTask == -1)
            {
                checkListBoxSubTasks.ClearSelected();
            }

            // Do the click check for category lsit
            int indexCategory = checkListBoxTicketCategory.IndexFromPoint(e.Location);

            // If no item selected
            if (indexCategory == -1)
            {
                checkListBoxTicketCategory.ClearSelected();
            }
        }

        #endregion

        #region Buttons

        // Create a subtask
        private void buttonCreateSubTask_Click(object sender, EventArgs e)
        {
            if (frmSubTask == null)
            {
                frmSubTask = new FormSubTask(this);
                frmSubTask.Show();
            }
        }

        // Remove Subtask
        private void buttonRemoveSubTask_Click(object sender, EventArgs e)
        {
            // If an item is selected
            if (checkListBoxSubTasks.SelectedItem != null)
            {
                // Create a message box asking if the user wants to remove this subtask
                DialogResult result = MessageBox.Show("Are you sure you want to remove this subtask?", "Remove SubTask", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    checkListBoxSubTasks.Items.Remove(checkListBoxSubTasks.SelectedItem);
                }
            }
            else
            {
                // Display error message.
                MessageBox.Show("No subtask selected to remove!", "Error: No SubTask selected", MessageBoxButtons.OK);
            }
        }

        // Button Create/Save Ticket
        private void buttonTicketCreate_Click(object sender, EventArgs e)
        {
            // If a name is provided
            if(textBoxTicketName.Text != "")
            {
                ApplyNewTicketData();
            }
            else
            {
                MessageBox.Show("Please provide a Ticket Name", "ERROR! NO TICKET NAME FOUND", MessageBoxButtons.OK);
            }
        }

        // Button Cancel Ticket
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(mode == TicketWindowMode.Modify)
            {
                // Add the ticket back
                if (frmMain.isOnOpenList)
                {
                    frmMain.openList.Add(ticket);
                }
                else
                {
                    frmMain.closedList.Add(ticket);
                }
            }

            Exit(false);
        }

        // Radio button selection 
        private void radioButtonOpenList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpenList.Checked)
            {
                radioButtonClosedList.Checked = false;
            }
        }

        // Button Delete Ticket
        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
            Exit(true);
        }

        #endregion

        #region Other
        // CheckListBox ticketCategory on item checked
        private void checkListBoxTicketCategory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // If this new value is checked, then set all others as unchecked.
            if(e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkListBoxTicketCategory.Items.Count; i++)
                {
                    checkListBoxTicketCategory.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        #endregion

        #region Private Methods

        // Creates and adds the new ticket data to mainFrom
        private Ticket ApplyNewTicketData()
        {
            // Create the returnTicket 
            Ticket returnTicket = new Ticket("", "", "", null, 0);

            // Makes sure a category has been chosen.
            if (checkListBoxTicketCategory.CheckedItems.Count != 0)
            {
                // Set the timeSpent
                if (ticket != null)
                {
                    returnTicket.timeSpent = ticket.timeSpent;
                }

                // Used for category creation
                string categoryName = "";
                int categoryValue = 0;
                
                // Loop through and find the checked index.
                for(int i = 0; i < checkListBoxTicketCategory.Items.Count; i++)
                {
                    if (checkListBoxTicketCategory.GetItemChecked(i))
                    {
                        categoryName = checkListBoxTicketCategory.Items[i].ToString();
                        categoryValue = i;
                    }
                }

                // Set the ticket category data
                returnTicket.category = new Category(categoryName, categoryValue);

                // Set other data
                returnTicket.name = textBoxTicketName.Text;
                returnTicket.displayName = "[" + returnTicket.category.name + "] " + returnTicket.name;
                returnTicket.description = richTextTicket.Text;
              
                // Create subtasks
                for (int i = 0; i < checkListBoxSubTasks.Items.Count; i++)
                {
                    CheckState checkState = checkListBoxSubTasks.GetItemCheckState(i);
                    string taskName = checkListBoxSubTasks.Items[i].ToString();
                    returnTicket.subTasks.Add(new SubTask(taskName, checkState));
                }

                Exit(false);
            }
            else
            {
                // Display error warning
                MessageBox.Show("Please select a category in order to create new ticket.", "ERROR! TICKET CREATION FAILED", MessageBoxButtons.OK);

                // Return empty ticket
                returnTicket = null;
            }

            // If a ticket was created
            if(returnTicket != null)
            {
                // Add ticket to correct list
                if (radioButtonOpenList.Checked)
                {
                    frmMain.openList.Add(returnTicket);
                }
                else
                {
                    frmMain.closedList.Add(returnTicket);
                }

                // Update mainFormData
                frmMain.LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
            }

            return returnTicket;
        }

        private void Exit(bool updateFrmMainListView)
        {
            if (frmSubTask == null)
            {
                frmMain.frmTicket = null;
                Close();

                if (updateFrmMainListView)
                {
                    // Update mainFormData
                    frmMain.LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
                }
            }
        }

        #endregion

        // Shortcuts ALL SHORTCUTS ARE DIRECT COPIES
        private void FormTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Exit(false);
            }

            if(e.KeyCode == Keys.Enter)
            {
                // If a name is provided
                if (textBoxTicketName.Text != "")
                {
                    ApplyNewTicketData();
                }
                else
                {
                    MessageBox.Show("Please provide a Ticket Name", "ERROR! NO TICKET NAME FOUND", MessageBoxButtons.OK);
                }
            }
        }
    }
}
