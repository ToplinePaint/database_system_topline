using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_app_test
{
    public partial class StyleForm : Form
    {
        //THIS IS A PRACTICE FORM ONLY!!!
        public StyleForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign() { subPanelSideMenu.Visible = false; }
        private void ctrlSubList(Panel subPanel)
        {
            //if its closed open it
            if (subPanel.Visible == false)
                subPanel.Visible = true;
            //else if its open shut it
            else subPanel.Visible = false;
        }

        private void accordionSide1_Click(object sender, EventArgs e) { ctrlSubList(subPanelSideMenu); } 
    }
}
