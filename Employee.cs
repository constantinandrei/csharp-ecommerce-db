// See https://aka.ms/new-console-template for more information
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Level { get; set; }
    public List<Order> Orders { get; set; }
    public override string ToString()
    {
        return Convert.ToString(Id).PadLeft(2, ' ') + ". " + Name.PadRight(25, ' ') + Surname.PadRight(25, ' ') + Level;
    }

    public static void PrintEmployeesList(List<Employee> employees)
    {

        Console.WriteLine(" id nome                     cognome                  livello");
        foreach (Employee employee in employees)
        {

            Console.WriteLine(employee.ToString());
        }
    }
    public static void Seed()
    {
        ECommerceContext db = new ECommerceContext();
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Name = "Mattia", Surname = "Reino", Level = 5});
        employees.Add(new Employee { Name = "Guido", Surname = "Zucchelli", Level = 3});
        employees.Add(new Employee { Name = "Jacopo", Surname = "Sardelli", Level = 1});
        foreach (Employee employee in employees)
        {
            db.Employees.Add(employee);
        }
        db.SaveChanges();
    }
}