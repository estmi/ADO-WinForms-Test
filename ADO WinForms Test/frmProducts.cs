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
    public partial class frmProducts : Form
    {
        classiccarDataSet ds;
        DataView dvProducts;

        public frmProducts()
        {

            InitializeComponent();
        }
        public frmProducts(classiccarDataSet ds) : this()
        {
            this.ds = ds;
            dvProducts = new DataView(ds.products);
        }
        protected override void OnLoad(EventArgs e)
        {
            productlinesTableAdapter1.Fill(ds.productlines);
            comboBox1.DataSource = ds.productlines;
            comboBox1.ValueMember = "productline";
            comboBox1.DisplayMember = "productline";
            productsTableAdapter1.Fill(ds.products);
            dataGridView1.DataSource = dvProducts;
            dataGridView1.Columns["productDescription"].Visible = false;
            dataGridView1.AutoResizeColumns();

            base.OnLoad(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvProducts.RowFilter = $"productline like '{comboBox1.Text}'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvProducts.RowFilter = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvProducts.Sort = "quantityInStock DESC";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dvProducts.Sort = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dvProducts.RowStateFilter = DataViewRowState.ModifiedCurrent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dvProducts.RowStateFilter = DataViewRowState.ModifiedOriginal;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(ds.products);
            dvProducts.RowStateFilter = DataViewRowState.CurrentRows;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Update(ds.products);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dvProducts.RowStateFilter = DataViewRowState.Added;
        }
    }
}
