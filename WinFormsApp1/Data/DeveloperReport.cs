using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Data;

public class DeveloperReport
{
    [Key]
    public int DevRepo_ID { get; set; }

    [Required]
    public string Product_Status { get; set; }

    public int Price_Quote { get; set; }

    public string Delivery_ETA { get; set; }

    public string Notes { get; set; }

    // Foreign Key
    public int RequestID_FK { get; set; }

    // Navigation Properties
    public CustomerRequest CustomerRequest { get; set; }

    public CostReport CostReport { get; set; }
}
