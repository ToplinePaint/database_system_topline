using System;
using System.Windows.Forms;

namespace database_app_test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            panelChildForm.SendToBack();
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            openChildForm(new Ordering());
        }
    }
}
