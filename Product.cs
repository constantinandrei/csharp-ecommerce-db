// See https://aka.ms/new-console-template for more information
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public List<Order> Orders { get; set; }
    public static void Seed()
    {
        ECommerceContext db = new ECommerceContext();
        List<Product> products = new List<Product>();
        products.Add(new Product { Name = "bici", Description = "per viaggiare", Price = 2300.00f});
        products.Add(new Product { Name = "pc", Description = "per programmare", Price = 4500.00f});
        products.Add(new Product { Name = "lavatrice", Description = "per lavare", Price = 499.00f});
        products.Add(new Product { Name = "asciugatrice", Description = "per asciugare", Price = 2300.00f});
        products.Add(new Product { Name = "forno", Description = "per cuocere", Price = 1799.00f});
        products.Add(new Product { Name = "frullatore", Description = "per frullare", Price = 287.00f});
        products.Add(new Product { Name = "telefono", Description = "per instagram", Price = 1399.00f});
        products.Add(new Product { Name = "frigorifero", Description = "per refrigerare", Price = 1279.00f});
        products.Add(new Product { Name = "caricabatterie", Description = "per caricare", Price = 19.90f});
        products.Add(new Product { Name = "lampadina", Description = "per vedere", Price = 2.59f});
        foreach (Product product in products)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}