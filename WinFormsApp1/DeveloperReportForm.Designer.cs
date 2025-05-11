namespace WinFormsApp1
{
    partial class DeveloperReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.TextBox txtLogs;

        private System.Windows.Forms.Label lblResourceUsage;
        private System.Windows.Forms.TextBox txtResourceUsage;

        private System.Windows.Forms.Label lblMonitoring;
        private System.Windows.Forms.TextBox txtMonitoringUrl;

        private System.Windows.Forms.Label lblNextSteps;
        private System.Windows.Forms.TextBox txtNextSteps;

        private System.Windows.Forms.Label lblBusinessReq;
        private System.Windows.Forms.TextBox txtBusinessReq;

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblLogs = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();

            this.lblResourceUsage = new System.Windows.Forms.Label();
            this.txtResourceUsage = new System.Windows.Forms.TextBox();

            this.lblMonitoring = new System.Windows.Forms.Label();
            this.txtMonitoringUrl = new System.Windows.Forms.TextBox();

            this.lblNextSteps = new System.Windows.Forms.Label();
            this.txtNextSteps = new System.Windows.Forms.TextBox();

            this.lblBusinessReq = new System.Windows.Forms.Label();
            this.txtBusinessReq = new System.Windows.Forms.TextBox();

            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();

            this.btnSubmit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 20);
            this.lblStatus.Text = "Projekta statuss:";

            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(180, 17);
            this.cmbStatus.Size = new System.Drawing.Size(200, 23);

            // lblLogs
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(30, 60);
            this.lblLogs.Text = "Kļūdu žurnāli:";

            // txtLogs
            this.txtLogs.Location = new System.Drawing.Point(180, 57);
            this.txtLogs.Size = new System.Drawing.Size(200, 23);

            // lblResourceUsage
            this.lblResourceUsage.AutoSize = true;
            this.lblResourceUsage.Location = new System.Drawing.Point(30, 100);
            this.lblResourceUsage.Text = "Resursu izmantošana:";

            // txtResourceUsage
            this.txtResourceUsage.Location = new System.Drawing.Point(180, 97);
            this.txtResourceUsage.Size = new System.Drawing.Size(200, 23);

            // lblMonitoring
            this.lblMonitoring.AutoSize = true;
            this.lblMonitoring.Location = new System.Drawing.Point(30, 140);
            this.lblMonitoring.Text = "Monitoringa galapunkts:";

            // txtMonitoringUrl
            this.txtMonitoringUrl.Location = new System.Drawing.Point(180, 137);
            this.txtMonitoringUrl.Size = new System.Drawing.Size(200, 23);

            // lblNextSteps
            this.lblNextSteps.AutoSize = true;
            this.lblNextSteps.Location = new System.Drawing.Point(30, 180);
            this.lblNextSteps.Text = "Nākamie soļi:";

            // txtNextSteps
            this.txtNextSteps.Location = new System.Drawing.Point(180, 177);
            this.txtNextSteps.Multiline = true;
            this.txtNextSteps.Size = new System.Drawing.Size(200, 60);

            // lblBusinessReq (conditionally visible)
            this.lblBusinessReq.AutoSize = true;
            this.lblBusinessReq.Location = new System.Drawing.Point(30, 250);
            this.lblBusinessReq.Text = "Uzņēmējdarbības prasības:";

            // txtBusinessReq
            this.txtBusinessReq.Location = new System.Drawing.Point(180, 247);
            this.txtBusinessReq.Multiline = true;
            this.txtBusinessReq.Size = new System.Drawing.Size(200, 60);

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 320);
            this.lblDate.Text = "Datums:";

            // dtpDate
            this.dtpDate.Location = new System.Drawing.Point(180, 317);
            this.dtpDate.Size = new System.Drawing.Size(200, 23);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(180, 360);
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Iesniegt";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // DeveloperReportForm
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.lblResourceUsage);
            this.Controls.Add(this.txtResourceUsage);
            this.Controls.Add(this.lblMonitoring);
            this.Controls.Add(this.txtMonitoringUrl);
            this.Controls.Add(this.lblNextSteps);
            this.Controls.Add(this.txtNextSteps);
            this.Controls.Add(this.lblBusinessReq);
            this.Controls.Add(this.txtBusinessReq);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSubmit);
            this.Name = "DeveloperReportForm";
            this.Text = "CloudTech ziņojums";
            this.Load += new System.EventHandler(this.DeveloperReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
