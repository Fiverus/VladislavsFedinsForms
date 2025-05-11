using System;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class FormOrder : Form
    {
        private readonly AppDbContext _context;

        public FormOrder(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new CustomerRequest
                {
                    Customer_Name = txtFullName.Text,
                    Customer_Email = txtEmail.Text,
                    Product_Name = txtProduct.Text,
                    Product_Amount = int.Parse(txtAmount.Text),
                    Customer_Address = txtNotes.Text, // Assuming address/notes used here
                    Customer_Mobile = 0 // You may adapt or extend to capture mobile
                };

                _context.CustomerRequests.Add(request);
                _context.SaveChanges();

                MessageBox.Show("Pasūtījums veiksmīgi iesniegts!", "Apstiprinājums", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda iesniedzot pasūtījumu: " + ex.Message, "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}