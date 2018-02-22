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
    public partial class FormSubTask : Form
    {
        private FormTicket frmTicket;

        public FormSubTask(FormTicket frmTicket)
        {
            InitializeComponent();

            // Setup references
            this.frmTicket = frmTicket;
        }

        // On Cancel button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        // On Create Button
        private void buttonCreateSubTask_Click(object sender, EventArgs e)
        {
            if(textBoxSubTaskName.Text != "")
            {
                frmTicket.checkListBoxSubTasks.Items.Add(textBoxSubTaskName.Text);
                Exit();
            }
            else
            {
                MessageBox.Show("No SubTask name given!", "Error! No name given.", MessageBoxButtons.OK);
            }
        }

        private void Exit()
        {
            frmTicket.frmSubTask = null;
            Close();
        }

        private void FormSubTask_KeyDown(object sender, KeyEventArgs e)
        {
            // Exit
            if (e.KeyCode == Keys.Escape)
            {
                Exit();
            }

            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSubTaskName.Text != "")
                {
                    frmTicket.checkListBoxSubTasks.Items.Add(textBoxSubTaskName.Text);
                    Exit();
                }
                else
                {
                    MessageBox.Show("No SubTask name given!", "Error! No name given.", MessageBoxButtons.OK);
                }
            }
        }
    }
}
