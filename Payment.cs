// See https://aka.ms/new-console-template for more information
public class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public bool Status { get; set; } 
    public int OrderId { get; set; }
    public Order Order { get; set; }
}