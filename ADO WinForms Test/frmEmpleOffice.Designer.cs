
namespace ADO_WinForms_Test
{
    partial class frmEmpleOffice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleats = new System.Windows.Forms.DataGridView();
            this.employeesTableAdapter1 = new ADO_WinForms_Test.classiccarDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleats
            // 
            this.dgvEmpleats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleats.Location = new System.Drawing.Point(12, 52);
            this.dgvEmpleats.Name = "dgvEmpleats";
            this.dgvEmpleats.Size = new System.Drawing.Size(776, 386);
            this.dgvEmpleats.TabIndex = 0;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEmpleOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmpleats);
            this.Name = "frmEmpleOffice";
            this.Text = "frmEmpleOffice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleats;
        private classiccarDataSetTableAdapters.employeesTableAdapter employeesTableAdapter1;
    }
}