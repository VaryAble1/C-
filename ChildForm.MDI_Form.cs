using System;
using System.Windows.Forms;

namespace MDI_Form
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        // Click Me
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Do That!");
        }
    }
// thanks for looking
}
