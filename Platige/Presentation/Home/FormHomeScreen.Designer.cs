namespace Platige.Presentation.Home
{
    partial class FormHomeScreen
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
            GbContractors = new GroupBox();
            BtnGenerateContractors = new Button();
            BtnContractorsExport = new Button();
            BtnContractorsList = new Button();
            BtnAddNewContractor = new Button();
            GbInvoices = new GroupBox();
            BtnInvoicesExport = new Button();
            BtnInvoicesList = new Button();
            BtnGenerateInvoices = new Button();
            button5 = new Button();
            BtnAddNewInvoice = new Button();
            GbReports = new GroupBox();
            BtnCountryContractorsReport = new Button();
            BtnInvoicesMonthlyReport = new Button();
            button10 = new Button();
            BtnContractorInvoicesReport = new Button();
            GbContractors.SuspendLayout();
            GbInvoices.SuspendLayout();
            GbReports.SuspendLayout();
            SuspendLayout();
            // 
            // GbContractors
            // 
            GbContractors.Controls.Add(BtnGenerateContractors);
            GbContractors.Controls.Add(BtnContractorsExport);
            GbContractors.Controls.Add(BtnContractorsList);
            GbContractors.Controls.Add(BtnAddNewContractor);
            GbContractors.Location = new Point(12, 12);
            GbContractors.Name = "GbContractors";
            GbContractors.Size = new Size(234, 323);
            GbContractors.TabIndex = 0;
            GbContractors.TabStop = false;
            GbContractors.Text = "Kontraktorzy";
            // 
            // BtnGenerateContractors
            // 
            BtnGenerateContractors.Location = new Point(16, 105);
            BtnGenerateContractors.Name = "BtnGenerateContractors";
            BtnGenerateContractors.Size = new Size(201, 50);
            BtnGenerateContractors.TabIndex = 1;
            BtnGenerateContractors.Text = "Generuj kontrahentów";
            BtnGenerateContractors.UseVisualStyleBackColor = true;
            BtnGenerateContractors.Click += BtnGenerateContractors_Click;
            // 
            // BtnContractorsExport
            // 
            BtnContractorsExport.Location = new Point(16, 245);
            BtnContractorsExport.Name = "BtnContractorsExport";
            BtnContractorsExport.Size = new Size(201, 50);
            BtnContractorsExport.TabIndex = 3;
            BtnContractorsExport.Text = "Eksportuj (CSV | XML)";
            BtnContractorsExport.UseVisualStyleBackColor = true;
            BtnContractorsExport.Click += BtnContractorsExport_Click;
            // 
            // BtnContractorsList
            // 
            BtnContractorsList.Location = new Point(16, 173);
            BtnContractorsList.Name = "BtnContractorsList";
            BtnContractorsList.Size = new Size(201, 50);
            BtnContractorsList.TabIndex = 2;
            BtnContractorsList.Text = "Lista kontrahentów";
            BtnContractorsList.UseVisualStyleBackColor = true;
            BtnContractorsList.Click += BtnContractorsList_Click;
            // 
            // BtnAddNewContractor
            // 
            BtnAddNewContractor.Location = new Point(16, 40);
            BtnAddNewContractor.Name = "BtnAddNewContractor";
            BtnAddNewContractor.Size = new Size(201, 50);
            BtnAddNewContractor.TabIndex = 0;
            BtnAddNewContractor.Text = "Dodaj nowego kontrahenta";
            BtnAddNewContractor.UseVisualStyleBackColor = true;
            BtnAddNewContractor.Click += BtnAddNewContractor_Click;
            // 
            // GbInvoices
            // 
            GbInvoices.Controls.Add(BtnInvoicesExport);
            GbInvoices.Controls.Add(BtnInvoicesList);
            GbInvoices.Controls.Add(BtnGenerateInvoices);
            GbInvoices.Controls.Add(button5);
            GbInvoices.Controls.Add(BtnAddNewInvoice);
            GbInvoices.Location = new Point(281, 12);
            GbInvoices.Name = "GbInvoices";
            GbInvoices.Size = new Size(234, 323);
            GbInvoices.TabIndex = 4;
            GbInvoices.TabStop = false;
            GbInvoices.Text = "Faktury";
            // 
            // BtnInvoicesExport
            // 
            BtnInvoicesExport.Location = new Point(16, 245);
            BtnInvoicesExport.Name = "BtnInvoicesExport";
            BtnInvoicesExport.Size = new Size(201, 50);
            BtnInvoicesExport.TabIndex = 3;
            BtnInvoicesExport.Text = "Eksportuj (CSV | XML)";
            BtnInvoicesExport.UseVisualStyleBackColor = true;
            BtnInvoicesExport.Click += BtnInvoicesExport_Click;
            // 
            // BtnInvoicesList
            // 
            BtnInvoicesList.Location = new Point(16, 173);
            BtnInvoicesList.Name = "BtnInvoicesList";
            BtnInvoicesList.Size = new Size(201, 50);
            BtnInvoicesList.TabIndex = 2;
            BtnInvoicesList.Text = "Lista faktur";
            BtnInvoicesList.UseVisualStyleBackColor = true;
            BtnInvoicesList.Click += BtnInvoicesList_Click;
            // 
            // BtnGenerateInvoices
            // 
            BtnGenerateInvoices.Location = new Point(17, 105);
            BtnGenerateInvoices.Name = "BtnGenerateInvoices";
            BtnGenerateInvoices.Size = new Size(201, 50);
            BtnGenerateInvoices.TabIndex = 2;
            BtnGenerateInvoices.Text = "Generuj faktury";
            BtnGenerateInvoices.UseVisualStyleBackColor = true;
            BtnGenerateInvoices.Click += BtnGenerateInvoices_Click;
            // 
            // button5
            // 
            button5.Location = new Point(16, 105);
            button5.Name = "button5";
            button5.Size = new Size(201, 50);
            button5.TabIndex = 1;
            button5.Text = "Generuj kontraktorów";
            button5.UseVisualStyleBackColor = true;
            // 
            // BtnAddNewInvoice
            // 
            BtnAddNewInvoice.Location = new Point(16, 40);
            BtnAddNewInvoice.Name = "BtnAddNewInvoice";
            BtnAddNewInvoice.Size = new Size(201, 50);
            BtnAddNewInvoice.TabIndex = 0;
            BtnAddNewInvoice.Text = "Dodaj nową fakturę";
            BtnAddNewInvoice.UseVisualStyleBackColor = true;
            BtnAddNewInvoice.Click += BtnAddNewInvoice_Click;
            // 
            // GbReports
            // 
            GbReports.Controls.Add(BtnCountryContractorsReport);
            GbReports.Controls.Add(BtnInvoicesMonthlyReport);
            GbReports.Controls.Add(button10);
            GbReports.Controls.Add(BtnContractorInvoicesReport);
            GbReports.Location = new Point(554, 12);
            GbReports.Name = "GbReports";
            GbReports.Size = new Size(234, 323);
            GbReports.TabIndex = 5;
            GbReports.TabStop = false;
            GbReports.Text = "Raporty";
            // 
            // BtnCountryContractorsReport
            // 
            BtnCountryContractorsReport.Location = new Point(16, 173);
            BtnCountryContractorsReport.Name = "BtnCountryContractorsReport";
            BtnCountryContractorsReport.Size = new Size(201, 50);
            BtnCountryContractorsReport.TabIndex = 2;
            BtnCountryContractorsReport.Text = "Krajowi kontrahenci";
            BtnCountryContractorsReport.UseVisualStyleBackColor = true;
            BtnCountryContractorsReport.Click += BtnCountryContractorsReport_Click;
            // 
            // BtnInvoicesMonthlyReport
            // 
            BtnInvoicesMonthlyReport.Location = new Point(17, 105);
            BtnInvoicesMonthlyReport.Name = "BtnInvoicesMonthlyReport";
            BtnInvoicesMonthlyReport.Size = new Size(201, 50);
            BtnInvoicesMonthlyReport.TabIndex = 2;
            BtnInvoicesMonthlyReport.Text = "Faktury miesięcznie";
            BtnInvoicesMonthlyReport.UseVisualStyleBackColor = true;
            BtnInvoicesMonthlyReport.Click += BtnInvoicesMonthlyReport_Click;
            // 
            // button10
            // 
            button10.Location = new Point(16, 105);
            button10.Name = "button10";
            button10.Size = new Size(201, 50);
            button10.TabIndex = 1;
            button10.Text = "Generuj kontraktorów";
            button10.UseVisualStyleBackColor = true;
            // 
            // BtnContractorInvoicesReport
            // 
            BtnContractorInvoicesReport.Location = new Point(16, 40);
            BtnContractorInvoicesReport.Name = "BtnContractorInvoicesReport";
            BtnContractorInvoicesReport.Size = new Size(201, 50);
            BtnContractorInvoicesReport.TabIndex = 0;
            BtnContractorInvoicesReport.Text = "Faktury kontrahenta";
            BtnContractorInvoicesReport.UseVisualStyleBackColor = true;
            BtnContractorInvoicesReport.Click += BtnContractorInvoicesReport_Click;
            // 
            // FormHomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(GbReports);
            Controls.Add(GbInvoices);
            Controls.Add(GbContractors);
            MaximizeBox = false;
            Name = "FormHomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Platige";
            FormClosed += FormHomeScreen_FormClosed;
            GbContractors.ResumeLayout(false);
            GbInvoices.ResumeLayout(false);
            GbReports.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbContractors;
        private Button BtnAddNewContractor;
        private Button BtnContractorsList;
        private Button BtnContractorsExport;
        private GroupBox GbInvoices;
        private Button BtnInvoicesExport;
        private Button BtnInvoicesList;
        private Button BtnGenerateInvoices;
        private Button button5;
        private Button BtnAddNewInvoice;
        private GroupBox GbReports;
        private Button BtnCountryContractorsReport;
        private Button BtnInvoicesMonthlyReport;
        private Button button10;
        private Button BtnContractorInvoicesReport;
        private Button BtnGenerateContractors;
    }
}