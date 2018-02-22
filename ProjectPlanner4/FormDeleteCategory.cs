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
    public partial class FormDeleteCategory : Form
    {
        private FormSettings frmSettings = null;
        private string deleteCategoryName = "";

        public FormDeleteCategory(FormSettings frmSettings, int deleteCategoryIndex, string deleteCategoryName)
        {
            InitializeComponent();

            // Setup references
            this.frmSettings = frmSettings;
            this.deleteCategoryName = deleteCategoryName;

            // Set text box text
            textBoxCategoryToDelete.Text = deleteCategoryName;

            // Load category data
            Functions.LoadCategoryDataTo(checkListBoxCategories, false);

            // Remove the category that is about to be removed from this list
            checkListBoxCategories.Items.RemoveAt(deleteCategoryIndex - 1);

            // Set the default check selection
            checkListBoxCategories.SetItemCheckState(0, CheckState.Checked);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Need to find the one selected item
            string replaceCategory = "";
            int numberOfCheckedItems = 0;

            // Find the checked item
            for(int i = 0; i < checkListBoxCategories.Items.Count; i++)
            {
                if (checkListBoxCategories.GetItemChecked(i))
                {
                    replaceCategory = checkListBoxCategories.Items[i].ToString();
                    numberOfCheckedItems++;
                }
            }

            // If there is only one checkbox
            if(numberOfCheckedItems == 1)
            {
                // Replace
                Functions.ReplaceCategory(deleteCategoryName, replaceCategory, frmSettings.frmMain.openList, frmSettings.frmMain.closedList);
                
                // Refresh main graphics, and settings graphics.
                frmSettings.frmMain.LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
                frmSettings.RefreshListBox();
                Exit();
            }
            else
            {
                MessageBox.Show("Cannot delete! Multiple replace categories selected.", "Error! Cannot delete.", MessageBoxButtons.OK);
            }
        }

        private void Exit()
        {
            frmSettings.frmDeleteCategory = null;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        // Allows only one checkbox at the time
        private void checkListBoxCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkListBoxCategories.Items.Count; i++)
                {
                    checkListBoxCategories.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void FormDeleteCategory_KeyDown(object sender, KeyEventArgs e)
        {
            // Exit
            if (e.KeyCode == Keys.Escape)
            {
                Exit();
            }

            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Need to find the one selected item
                string replaceCategory = "";
                int numberOfCheckedItems = 0;

                // Find the checked item
                for (int i = 0; i < checkListBoxCategories.Items.Count; i++)
                {
                    if (checkListBoxCategories.GetItemChecked(i))
                    {
                        replaceCategory = checkListBoxCategories.Items[i].ToString();
                        numberOfCheckedItems++;
                    }
                }

                // If there is only one checkbox
                if (numberOfCheckedItems == 1)
                {
                    // Replace
                    Functions.ReplaceCategory(deleteCategoryName, replaceCategory, frmSettings.frmMain.openList, frmSettings.frmMain.closedList);

                    // Refresh main graphics, and settings graphics.
                    frmSettings.frmMain.LoadComboAndViewData(LoadState.Both, new Category("All", 0), 0);
                    frmSettings.RefreshListBox();
                    Exit();
                }
                else
                {
                    MessageBox.Show("Cannot delete! Multiple replace categories selected.", "Error! Cannot delete.", MessageBoxButtons.OK);
                }
            }
        }
    }
}
