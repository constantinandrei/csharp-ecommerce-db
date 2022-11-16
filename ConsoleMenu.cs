// See https://aka.ms/new-console-template for more information

// Product.Seed();
// Employee.Seed();
// Customer.Seed();

public class ConsoleMenu
{
    public Employee ActiveEmployee { get; set; }
    public static void Start()
    {
        ECommerceContext db = new ECommerceContext();
        bool on = true;
        Console.Clear();
        Console.WriteLine("1. Dipendente");
        Console.WriteLine("2. Utente");
        Console.WriteLine("9. Esci");
        Console.WriteLine();
        int sceltaUtente = MyUtilities.ChiediInt("Selezionare un opzione:");

        while (on)
        {
            switch (sceltaUtente)
            {
                case 1:
                    Console.Clear();
                    Employee.PrintEmployeesList(db.Employees.ToList());
                    Console.WriteLine();
                    int idEmployee = MyUtilities.ChiediInt("Selezionare con quale utente entrare");
                    Employee employee = db.Employees.Where(x => x.Id == idEmployee).FirstOrDefault();
                    Console.WriteLine("Impiegato loggato: {0}, {1}", employee.Name, employee.Surname);
                    MyUtilities.Continua();
                    on = false;
                    break;
                case 9:
                    on = false;
                    break;
                default:
                    break;
            }
        }
    }
}
