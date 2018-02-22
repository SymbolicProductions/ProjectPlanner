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
    public partial class FormDocumentation : Form
    {
        public FormDocumentation()
        {
            InitializeComponent();
        }

        private void FormDocumentation_KeyDown(object sender, KeyEventArgs e)
        {
            // Exit
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
