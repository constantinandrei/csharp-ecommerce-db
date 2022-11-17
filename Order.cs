// See https://aka.ms/new-console-template for more information
public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public string Status { get; set; }
    public int? CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }  
    public List<Product> Products { get; set; }
    public void Print()
    {
        Console.WriteLine("Ordine: " + Convert.ToString(Id));
        Console.WriteLine("Stato: " + Status);
        Console.WriteLine("Totale: " + Amount);
        Console.WriteLine("Dipendente: " + Employee.Name + " " + Employee.Surname);
        if (Customer != null)
            Console.WriteLine("Cliente: " + Customer.Name + " " + Customer.Surname);
        Console.WriteLine("Prodotti: ");
        if (Products != null)
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }
}