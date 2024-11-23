namespace Platige.Presentation.Home
{
    partial class FormDbConnection
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
            lblServerName = new Label();
            lblDbName = new Label();
            lblUser = new Label();
            lblPassword = new Label();
            tbServerName = new TextBox();
            tbDbName = new TextBox();
            tbUser = new TextBox();
            tbPassword = new TextBox();
            btnConnectCreateDb = new Button();
            SuspendLayout();
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Location = new Point(53, 29);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(102, 20);
            lblServerName.TabIndex = 0;
            lblServerName.Text = "Adres serwera";
            // 
            // lblDbName
            // 
            lblDbName.AutoSize = true;
            lblDbName.Location = new Point(15, 77);
            lblDbName.Name = "lblDbName";
            lblDbName.Size = new Size(140, 20);
            lblDbName.TabIndex = 1;
            lblDbName.Text = "Nazwa bazy danych";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(71, 124);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(84, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Użytkownik";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(108, 171);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(47, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Hasło";
            // 
            // tbServerName
            // 
            tbServerName.Location = new Point(177, 26);
            tbServerName.Name = "tbServerName";
            tbServerName.Size = new Size(367, 27);
            tbServerName.TabIndex = 4;
            tbServerName.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // tbDbName
            // 
            tbDbName.Location = new Point(177, 74);
            tbDbName.Name = "tbDbName";
            tbDbName.Size = new Size(367, 27);
            tbDbName.TabIndex = 5;
            tbDbName.Text = "PlatigeDb";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(177, 121);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(367, 27);
            tbUser.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(177, 168);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(367, 27);
            tbPassword.TabIndex = 7;
            // 
            // btnConnectCreateDb
            // 
            btnConnectCreateDb.AutoSize = true;
            btnConnectCreateDb.Location = new Point(177, 246);
            btnConnectCreateDb.Name = "btnConnectCreateDb";
            btnConnectCreateDb.Size = new Size(209, 47);
            btnConnectCreateDb.TabIndex = 8;
            btnConnectCreateDb.Text = "Połącz / Utwórz bazę danych";
            btnConnectCreateDb.UseVisualStyleBackColor = true;
            btnConnectCreateDb.Click += BtnConnectCreateDb_Click;
            // 
            // FormDbConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 349);
            Controls.Add(btnConnectCreateDb);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(tbDbName);
            Controls.Add(tbServerName);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(lblDbName);
            Controls.Add(lblServerName);
            MaximizeBox = false;
            Name = "FormDbConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Platige";
            FormClosed += FormDbConnection_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServerName;
        private Label lblDbName;
        private Label lblUser;
        private Label lblPassword;
        private TextBox tbServerName;
        private TextBox tbDbName;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Button btnConnectCreateDb;
    }
}