﻿// See https://aka.ms/new-console-template for more information

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
        Console.WriteLine("9. Esci");
        Console.WriteLine();
        int sceltaUtente = MyUtilities.ChiediInt("Selezionare un opzione:");

        while (on)
        {
            switch (sceltaUtente)
            {
                case 1:
                    LoginDipendente();
                    break;
                case 9:
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
        Console.WriteLine("Impiegato loggato: {0}, {1}", ActiveEmployee.Name, ActiveEmployee.Surname);
        Console.WriteLine("1. Dipendente");
        Console.WriteLine("2. Utente");
        Console.WriteLine("9. Indietro");
        Console.WriteLine();
        int sceltaUtente = MyUtilities.ChiediInt("Selezionare un opzione:");
        switch (sceltaUtente)
        {
            case 9:
                Start();
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
        Console.WriteLine("Impiegato loggato: {0}, {1}", ActiveEmployee.Name, ActiveEmployee.Surname);
        MyUtilities.Continua();
        MenuDipendente();
    }
}
