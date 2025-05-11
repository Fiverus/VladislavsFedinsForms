using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Data;

public class OrderReport
{
    [Key]
    public int OrderRep_ID { get; set; }

    public string Order_Summary { get; set; }

    public string Payment_Details { get; set; }

    public string Invoice_Number { get; set; }

    // Foreign Key
    public int Confirmation_ID { get; set; }

    // Navigation Properties
    public PaymentConfirmation PaymentConfirmation { get; set; }
    public ICollection<CostReport> CostReports { get; set; }
}
