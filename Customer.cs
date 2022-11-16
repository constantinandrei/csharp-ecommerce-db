// See https://aka.ms/new-console-template for more information
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; }

    public static void Seed()
    {
        ECommerceContext db = new ECommerceContext();
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer { Name = "Andrei", Surname = "Constantin", Email = "andrei@mail.com" });
        customers.Add(new Customer { Name = "Amelia", Surname = "Lupo", Email = "amelia@mail.com" });
        customers.Add(new Customer { Name = "Fabio", Surname = "Biestra", Email = "fabio@mail.com" });
        foreach (Customer customer in customers)
        {
            db.Customers.Add(customer);
        }
        db.SaveChanges();
    }
}