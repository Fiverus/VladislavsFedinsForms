using System;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class DeveloperReportForm : Form
    {
        private readonly AppDbContext _context;
        private readonly bool _isSeniorDeveloper;

        public DeveloperReportForm(AppDbContext context, bool isSeniorDeveloper = false)
        {
            InitializeComponent();
            _context = context;
            _isSeniorDeveloper = isSeniorDeveloper;
        }

        private void DeveloperReportForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new[] { "Active", "Closed", "Mounted", "Configured" });
            cmbStatus.SelectedIndex = 0;
            txtBusinessReq.Visible = _isSeniorDeveloper;
            lblBusinessReq.Visible = _isSeniorDeveloper;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var report = new DeveloperReport
                {
                    Product_Status = cmbStatus.SelectedItem.ToString(),
                    Delivery_ETA = dtpDate.Value.ToShortDateString(),
                    Notes = txtNextSteps.Text,
                    // Custom mappings below (business rules)
                    Price_Quote = 0,
                };

                _context.DeveloperReports.Add(report);
                _context.SaveChanges();

                MessageBox.Show("Report submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}