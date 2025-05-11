using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Data;

public class CostReport
{
    [Key]
    public int CostReportID { get; set; }

    public int Price_Quote { get; set; }

    public string Delivery_ETA { get; set; }

    public string Notes { get; set; }

    // Foreign Keys
    public int DevRep_ID_FK { get; set; }
    public int? OrderRep_ID { get; set; }

    // Navigation Properties
    public DeveloperReport DeveloperReport { get; set; }
    public OrderReport OrderReport { get; set; }
}
