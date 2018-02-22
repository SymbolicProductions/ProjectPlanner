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
    public partial class FormSettings : Form
    {
        public FormMain frmMain = null;
        public FormDeleteCategory frmDeleteCategory = null;

        public FormSettings(FormMain frmMain)
        {
            InitializeComponent();

            // Setup references
            this.frmMain = frmMain;

            // Load Categories
            Functions.LoadCategoryDataTo(listBoxExistingCategories);
        }
        
        // Button Create Category
        private void buttonCategoryCreateNew_Click(object sender, EventArgs e)
        {
            if (textBoxCategoryNewName.Text != "")
            {
                // Add the new category
                Functions.categories.Add(new Category(textBoxCategoryNewName.Text, Functions.categories.Count));

                // Clear items and then load categories again.
                RefreshListBox();

                // Clear textBox
                textBoxCategoryNewName.Text = "";
            }
            else
            {
                MessageBox.Show("Cannot add category when no category name is provided.", "Error! Cannot add category.", MessageBoxButtons.OK);
            }
        }

        // Delete category
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxExistingCategories.SelectedIndex;

            if(selectedIndex != -1)
            {
                if (selectedIndex > 1)
                {
                    // Remove category
                    //Functions.categories.RemoveAt(listBoxExistingCategories.SelectedIndex);

                    frmDeleteCategory = new FormDeleteCategory(this, selectedIndex, Functions.categories[selectedIndex].name);
                    frmDeleteCategory.Show();

                    // Clear items and then load categories again.
                    //RefreshListBox();

                    // Go through all tickets open and closed
                    // If they have the old category name, set them to unassigned.
                }
                else
                {
                    MessageBox.Show("This category is system reserved.", "Error! Cannot remove system reserved.", MessageBoxButtons.OK);
                }
            }         
        }

        // Refreshes our list box
        public void RefreshListBox()
        {
            // Clear items and then load categories again.
            listBoxExistingCategories.Items.Clear();
            Functions.LoadCategoryDataTo(listBoxExistingCategories);
        }

        private void Exit()
        {       
            frmMain.frmCategory = null;
            Close();
        }

        // Button Close
        private void buttonClose_Click(object sender, EventArgs e)
        {          
            Exit();
        }

        // Key shortcuts SHORTCUTS ARE DIRECT COPIES
        private void FormCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Exit();
            }

            if(e.KeyCode == Keys.Enter)
            {
                if (textBoxCategoryNewName.Text != "")
                {
                    // Add the new category
                    Functions.categories.Add(new Category(textBoxCategoryNewName.Text, Functions.categories.Count));

                    // Clear items and then load categories again.
                    RefreshListBox();

                    // Clear textBox
                    textBoxCategoryNewName.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot add category when no category name is provided.", "Error! Cannot add category.", MessageBoxButtons.OK);
                }
            }
        }
    }
}
