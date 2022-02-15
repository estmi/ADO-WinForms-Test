using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_WinForms_Test
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.classiccarDataSet);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classiccarDataSet.orderdetails' table. You can move, or remove it, as needed.
            this.orderdetailsTableAdapter.Fill(this.classiccarDataSet.orderdetails);
            // TODO: This line of code loads data into the 'classiccarDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.classiccarDataSet.orders);

        }

        private void btnEmployeeOffice_Click(object sender, EventArgs e)
        {
            frmEmpleOffice frm = new frmEmpleOffice(classiccarDataSet)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var frm = new frmProducts(classiccarDataSet)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Show();
        }
    }
}
