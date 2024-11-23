namespace Platige.Presentation.Contractors
{
    partial class FormGenerateContractors
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
            btnGeneruj = new Button();
            lblContractorsNumber = new Label();
            nudContractorsNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudContractorsNumber).BeginInit();
            SuspendLayout();
            // 
            // btnGeneruj
            // 
            btnGeneruj.Location = new Point(164, 103);
            btnGeneruj.Name = "btnGeneruj";
            btnGeneruj.Size = new Size(156, 50);
            btnGeneruj.TabIndex = 15;
            btnGeneruj.Text = "Generuj";
            btnGeneruj.UseVisualStyleBackColor = true;
            btnGeneruj.Click += BtnGeneruj_Click;
            // 
            // lblContractorsNumber
            // 
            lblContractorsNumber.AutoSize = true;
            lblContractorsNumber.Location = new Point(28, 33);
            lblContractorsNumber.Name = "lblContractorsNumber";
            lblContractorsNumber.Size = new Size(264, 20);
            lblContractorsNumber.TabIndex = 16;
            lblContractorsNumber.Text = "Ilość kontrahentów do wygenerowania";
            // 
            // nudContractorsNumber
            // 
            nudContractorsNumber.Location = new Point(304, 31);
            nudContractorsNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudContractorsNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudContractorsNumber.Name = "nudContractorsNumber";
            nudContractorsNumber.Size = new Size(102, 27);
            nudContractorsNumber.TabIndex = 17;
            nudContractorsNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormGenerateContractors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 203);
            Controls.Add(nudContractorsNumber);
            Controls.Add(lblContractorsNumber);
            Controls.Add(btnGeneruj);
            MaximizeBox = false;
            Name = "FormGenerateContractors";
            Text = "Generuj kontrahentów";
            ((System.ComponentModel.ISupportInitialize)nudContractorsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneruj;
        private Label lblContractorsNumber;
        private NumericUpDown nudContractorsNumber;
    }
}