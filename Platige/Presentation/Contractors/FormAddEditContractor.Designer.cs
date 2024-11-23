namespace Platige.Presentation.Contractors
{
    partial class FormAddEditContractor
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
            lblType = new Label();
            tbType = new TextBox();
            lblName = new Label();
            lblShortName = new Label();
            lblCountry = new Label();
            lblAddress = new Label();
            lblNIP = new Label();
            lblIsActive = new Label();
            tbName = new TextBox();
            tbShortName = new TextBox();
            tbCountry = new TextBox();
            tbAddress = new TextBox();
            tbNIP = new TextBox();
            cbIsActive = new CheckBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(69, 15);
            lblType.Name = "lblType";
            lblType.Size = new Size(55, 20);
            lblType.TabIndex = 0;
            lblType.Text = "Rodzaj";
            // 
            // tbType
            // 
            tbType.Location = new Point(134, 12);
            tbType.MaxLength = 20;
            tbType.Name = "tbType";
            tbType.Size = new Size(494, 27);
            tbType.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Nazwa";
            // 
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Location = new Point(7, 103);
            lblShortName.Name = "lblShortName";
            lblShortName.Size = new Size(117, 20);
            lblShortName.TabIndex = 3;
            lblShortName.Text = "Nazwa skrócona";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(89, 145);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(35, 20);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Kraj";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(77, 187);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(47, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Adres";
            // 
            // lblNIP
            // 
            lblNIP.AutoSize = true;
            lblNIP.Location = new Point(92, 230);
            lblNIP.Name = "lblNIP";
            lblNIP.Size = new Size(32, 20);
            lblNIP.TabIndex = 6;
            lblNIP.Text = "NIP";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(60, 270);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(64, 20);
            lblIsActive.TabIndex = 7;
            lblIsActive.Text = "Aktywny";
            // 
            // tbName
            // 
            tbName.Location = new Point(134, 55);
            tbName.MaxLength = 50;
            tbName.Name = "tbName";
            tbName.Size = new Size(494, 27);
            tbName.TabIndex = 8;
            // 
            // tbShortName
            // 
            tbShortName.Location = new Point(134, 100);
            tbShortName.MaxLength = 20;
            tbShortName.Name = "tbShortName";
            tbShortName.Size = new Size(494, 27);
            tbShortName.TabIndex = 9;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(134, 142);
            tbCountry.MaxLength = 20;
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(494, 27);
            tbCountry.TabIndex = 10;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(134, 184);
            tbAddress.MaxLength = 100;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(494, 27);
            tbAddress.TabIndex = 11;
            // 
            // tbNIP
            // 
            tbNIP.Location = new Point(134, 227);
            tbNIP.MaxLength = 10;
            tbNIP.Name = "tbNIP";
            tbNIP.Size = new Size(494, 27);
            tbNIP.TabIndex = 12;
            tbNIP.KeyPress += tbNIP_KeyPress;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(134, 273);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(18, 17);
            cbIsActive.TabIndex = 13;
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(237, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 50);
            btnSave.TabIndex = 14;
            btnSave.Text = "Dodaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_ClickAsync;
            // 
            // FormAddEditContractor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 415);
            Controls.Add(btnSave);
            Controls.Add(cbIsActive);
            Controls.Add(tbNIP);
            Controls.Add(tbAddress);
            Controls.Add(tbCountry);
            Controls.Add(tbShortName);
            Controls.Add(tbName);
            Controls.Add(lblIsActive);
            Controls.Add(lblNIP);
            Controls.Add(lblAddress);
            Controls.Add(lblCountry);
            Controls.Add(lblShortName);
            Controls.Add(lblName);
            Controls.Add(tbType);
            Controls.Add(lblType);
            MaximizeBox = false;
            Name = "FormAddEditContractor";
            Text = "Dodaj nowego kontrahenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private TextBox tbType;
        private Label lblName;
        private Label lblShortName;
        private Label lblCountry;
        private Label lblAddress;
        private Label lblNIP;
        private Label lblIsActive;
        private TextBox tbName;
        private TextBox tbShortName;
        private TextBox tbCountry;
        private TextBox tbAddress;
        private TextBox tbNIP;
        private CheckBox cbIsActive;
        private Button btnSave;
    }
}