namespace WinFormsApp1.Data;
public class PaymentConfirmation
{
    public int Confirm_ID { get; set; }
    public bool Order_ApproveFlag { get; set; }
    public bool Payment_Confirmed { get; set; }
    public string Finance_Comments { get; set; }
}
