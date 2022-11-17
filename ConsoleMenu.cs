// See https://aka.ms/new-console-template for more information

// Product.Seed();
// Employee.Seed();
// Customer.Seed();

public class ConsoleMenu
{
    public Employee ActiveEmployee { get; set; }
    private ECommerceContext db;
    public ConsoleMenu()
    {
        db = new ECommerceContext();
    }
    public void Start()
    {
        bool on = true;
        Console.Clear();
        Console.WriteLine("1. Dipendente");
        Console.WriteLine("2. Utente");
        Console.WriteLine("0. Esci");
        Console.WriteLine();
        int sceltaUtente = MyUtilities.ChiediInt("Selezionare un opzione:");

        while (on)
        {
            switch (sceltaUtente)
            {
                case 1:
                    LoginDipendente();
                    on = false;
                    break;
                case 0:
                    on = false;
                    break;
                default:
                    break;
            }
        }
    }

    public void MenuDipendente()
    {
        Console.Clear();
        Console.WriteLine("Impiegato loggato: {0} {1}", ActiveEmployee.Name, ActiveEmployee.Surname);
        Console.WriteLine();
        Console.WriteLine("1. Aggiungi Ordine");
        Console.WriteLine("2. Modifica Ordini");
        Console.WriteLine("0. Indietro");
        Console.WriteLine();
        int sceltaUtente = MyUtilities.ChiediInt("Selezionare un opzione:");
        switch (sceltaUtente)
        {
            case 0:
                Start();
                break;
            case 1:
                AggiungiOrdine();
                break;
            default :
                break;
        }
    }

    public void LoginDipendente()
    {
        Console.Clear();
        Employee.PrintEmployeesList(db.Employees.ToList());
        Console.WriteLine();
        int idEmployee = MyUtilities.ChiediInt("Selezionare con quale utente entrare");
        ActiveEmployee = db.Employees.Where(x => x.Id == idEmployee).FirstOrDefault();
        Console.WriteLine("Impiegato loggato: {0} {1}", ActiveEmployee.Name, ActiveEmployee.Surname);
        MyUtilities.Continua();
        MenuDipendente();
    }

    public void AggiungiOrdine()
    {
        List<Product> products = db.Products.ToList();
        Product.PrintProducts(products);
        Console.WriteLine();
        List<Product> list = new List<Product>();
        bool adding = true;
        while (adding)
        {
            if (list.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Prodotti nell'ordine:");
                Product.PrintProducts(list);
                Console.WriteLine("------------------------");
                Console.WriteLine();
                bool continua = MyUtilities.SiNo("Vuoi aggiungere un altro prodotto? (si/no)");
                if (continua)
                {
                    Product.PrintProducts(products);
                } else
                {
                    adding = false;
                }
            }

            if (adding)
            {
                Console.WriteLine("");
                int scelta = MyUtilities.ChiediInt("Scegli il prodotto da inserire nell'ordine (ID): ");
                list.Add(db.Products.Where(x => x.Id == scelta).FirstOrDefault());
            }
            
        }

        Console.WriteLine("Inserimento ordine.....");

        float totaleOrdine = 0;
        foreach (Product product in list)
        {
            totaleOrdine += product.Price;
        }
        
        Order order = new Order();
        order.Products = list;
        order.Employee = ActiveEmployee;
        order.Date = new DateTime();
        order.Amount = totaleOrdine;
        order.Status = "vendita";
        db.Orders.Add(order);
        db.SaveChanges();
        
    }



    public void ModificaOrdini()
    {
       // 
    }
}
