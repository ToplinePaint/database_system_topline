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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }


        private DBControl Access = new DBControl();
        private void closeOrders_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region comboboxes
        //create string to store supplier
        private string matSupplier;

        private void NonSelection(ComboBox cb, string s)
        {
            cb.Items.Insert(0, "Select " + s + " From List");
            cb.SelectedIndex = 0;
        }
        private void PopError(ComboBox cb)
        {
            cb.Items.Insert(0, "" +
                "Population Error: No items found in the Database. " +
                "Please contact an admin!" +
                "");
            cb.SelectedIndex = 0;
        }

        private void getSuppliersList()
        {
            Access.ExecQuery("SELECT SupName FROM Supplier ORDER BY SupName ASC");

            foreach (DataRow r in Access.dbdt.Rows)
                cbxSupplier.Items.Add(r["SupName"]);

            //prevent clickthroughs
            NonSelection(cbxSupplier, "Suppliers");
        }
        private void getMaterialsList()
        {
            //Join the supplier and SupCode fields
            Access.ExecQuery(""+
                "SELECT DISTINCT Raw.supplier, Supplier.SupName, Raw.material " +
                "FROM Raw " +
                "INNER JOIN Raw ON Raw.supplier = Supplier.SupCode" +
                "");//needs to be ordered

            //annoying as f*** beep to say that its done da thing
            //replaced with annoying af msg box
            MessageBox.Show(matSupplier);

            //populate the cbx with rm_name entries where applicable
            foreach (DataRow row in Access.dbdt.Rows)
                cbxMaterial.Items.Add(row["material"]);

            //prevent clickthroughs
            if (cbxMaterial.Items.Count <= 1)
                PopError(cbxMaterial);

            else
                NonSelection(cbxMaterial, "Materials");
        }
        //if the cbxSupp is changed
        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSupplier.SelectedIndex == 0) {
                cbxMaterial.Enabled = false;
            }
            else
            {
                matSupplier = cbxSupplier.Text;
                cbxMaterial.Enabled = true;
                getMaterialsList();
            }
        }
        #endregion
        private void Orders_Load(object sender, EventArgs e)
        {
            Access.ExecQuery("SELECT ");
            cbxMaterial.Enabled = false;
            getSuppliersList();
        }
    }
}
