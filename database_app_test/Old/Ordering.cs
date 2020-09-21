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
    public partial class Ordering : Form
    {
        public Ordering()
        {
            InitializeComponent();
        }

        //Ordering functionality
        private DBControl Access = new DBControl();
        private bool NotEmpty (string text) { return !string.IsNullOrEmpty(text); }
        private void ExceptionsHandling (string text)
        {
            if (NotEmpty(text)) MessageBox.Show(text);
        }
        private void SrchSuppName (string searchString) // and it even has some fancy sql inj protection
        {
            Access.AddParam("@supplier", "%" + searchString + "%"); //uses paramaters to add wildcards
            Access.ExecQuery("SELECT * FROM Supplier WHERE SupName LIKE @supplier");// do the search

            ExceptionsHandling(Access.exceptions);//handle errors
            dgvData.DataSource = Access.dbdt;
        }
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SrchSuppName(suppSearcher.Text.ToString());
        }
        private void closeOrdering_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
