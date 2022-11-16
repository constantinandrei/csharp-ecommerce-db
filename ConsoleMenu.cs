﻿// See https://aka.ms/new-console-template for more information

// Product.Seed();
// Employee.Seed();
// Customer.Seed();

public class ConsoleMenu
{
    public static void Start()
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
                    Console.Clear();
                    Employee.PrintEmployeesList();
                    Console.WriteLine();
                    int idEmployee = MyUtilities.ChiediInt("Selezionare con quale utente entrare");
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
