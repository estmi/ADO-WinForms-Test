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
    public partial class frmEmpleOffice : Form
    {
        private classiccarDataSet ds;
        public frmEmpleOffice()
        {
            InitializeComponent();
        }
        public frmEmpleOffice(classiccarDataSet ds) : this()
        {
            this.ds = ds;
        }
        protected override void OnLoad(EventArgs e)
        {
            
            dgvEmpleats.DataSource = employeesTableAdapter1.GetDataEmployeesAndOffices();
            base.OnLoad(e);
        }
    }
}
