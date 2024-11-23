namespace Platige.Presentation.Reports
{
    partial class FormCountryContractorsReport
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
            dgvCountryContractors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCountryContractors).BeginInit();
            SuspendLayout();
            // 
            // dgvCountryContractors
            // 
            dgvCountryContractors.AllowUserToAddRows = false;
            dgvCountryContractors.AllowUserToDeleteRows = false;
            dgvCountryContractors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCountryContractors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCountryContractors.Dock = DockStyle.Fill;
            dgvCountryContractors.Location = new Point(0, 0);
            dgvCountryContractors.MultiSelect = false;
            dgvCountryContractors.Name = "dgvCountryContractors";
            dgvCountryContractors.ReadOnly = true;
            dgvCountryContractors.RowHeadersWidth = 51;
            dgvCountryContractors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCountryContractors.Size = new Size(800, 450);
            dgvCountryContractors.TabIndex = 2;
            // 
            // FormCountryContractors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCountryContractors);
            Name = "FormCountryContractors";
            Text = "Krajowi kontrahenci";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvCountryContractors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCountryContractors;
    }
}