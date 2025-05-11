namespace WinFormsApp1.Data;
public class CustomerRequest
{
    public int RequestID_PK { get; set; }
    public string Customer_Name { get; set; }
    public string Customer_Surname { get; set; }
    public string Customer_Email { get; set; }
    public int Customer_Mobile { get; set; }
    public string Customer_Address { get; set; }
    public string Product_Name { get; set; }
    public int Product_Amount { get; set; }

    public ICollection<DeveloperReport> DeveloperReports { get; set; }
}
