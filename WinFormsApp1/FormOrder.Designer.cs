namespace WinFormsApp1
{
    partial class FormOrder
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();

            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();

            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();

            this.btnSubmit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Labels and TextBoxes layout
            int leftLabel = 30, leftInput = 180, top = 20, spacing = 40;

            // Full Name
            this.lblFullName.Location = new System.Drawing.Point(leftLabel, top);
            this.lblFullName.Text = "Vārds/Uzvārds:";
            this.txtFullName.Location = new System.Drawing.Point(leftInput, top);
            this.txtFullName.Size = new System.Drawing.Size(200, 23);

            // Email
            top += spacing;
            this.lblEmail.Location = new System.Drawing.Point(leftLabel, top);
            this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(leftInput, top);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);

            // Product
            top += spacing;
            this.lblProduct.Location = new System.Drawing.Point(leftLabel, top);
            this.lblProduct.Text = "Produkts:";
            this.txtProduct.Location = new System.Drawing.Point(leftInput, top);
            this.txtProduct.Size = new System.Drawing.Size(200, 23);

            // Amount
            top += spacing;
            this.lblAmount.Location = new System.Drawing.Point(leftLabel, top);
            this.lblAmount.Text = "Daudzums:";
            this.txtAmount.Location = new System.Drawing.Point(leftInput, top);
            this.txtAmount.Size = new System.Drawing.Size(200, 23);

            // Notes
            top += spacing;
            this.lblNotes.Location = new System.Drawing.Point(leftLabel, top);
            this.lblNotes.Text = "Papildu piezīmes:";
            this.txtNotes.Location = new System.Drawing.Point(leftInput, top);
            this.txtNotes.Multiline = true;
            this.txtNotes.Size = new System.Drawing.Size(200, 60);

            // Date
            top += 70;
            this.lblDate.Location = new System.Drawing.Point(leftLabel, top);
            this.lblDate.Text = "Datums:";
            this.dtpDate.Location = new System.Drawing.Point(leftInput, top);
            this.dtpDate.Size = new System.Drawing.Size(200, 23);

            // Submit
            this.btnSubmit.Location = new System.Drawing.Point(leftInput, top + 40);
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Text = "Iesniegt";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, top + 100);
            this.Controls.AddRange(new Control[] {
                lblFullName, txtFullName,
                lblEmail, txtEmail,
                lblProduct, txtProduct,
                lblAmount, txtAmount,
                lblNotes, txtNotes,
                lblDate, dtpDate,
                btnSubmit
            });
            this.Text = "Pasūtījuma veidlapa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
