namespace Platige.Presentation.Contractors
{
    partial class FormContractorsList
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
            dgvContractors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContractors).BeginInit();
            SuspendLayout();
            // 
            // dgvContractors
            // 
            dgvContractors.AllowUserToAddRows = false;
            dgvContractors.AllowUserToDeleteRows = false;
            dgvContractors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContractors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContractors.Dock = DockStyle.Fill;
            dgvContractors.Location = new Point(0, 0);
            dgvContractors.MultiSelect = false;
            dgvContractors.Name = "dgvContractors";
            dgvContractors.ReadOnly = true;
            dgvContractors.RowHeadersWidth = 51;
            dgvContractors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContractors.Size = new Size(800, 450);
            dgvContractors.TabIndex = 0;
            dgvContractors.CellClick += DgvContractors_CellClick;
            // 
            // FormContractorsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvContractors);
            Name = "FormContractorsList";
            Text = "Platige - lista kontrahentów";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvContractors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContractors;
    }
}