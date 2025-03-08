using System;
using System.Drawing;
// 1.Soru

/*
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public virtual double CalculateBonus()
    {
        return 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Department: {Department}, Bonus: {CalculateBonus()}");
    }
}
class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.2;
    }
}

class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ahmet", 10000, "IT", 5);
        Developer developer = new Developer(2, "Mehmet", 8000, "Software", "Backend Developer");

        manager.DisplayInfo();
        developer.DisplayInfo();
    }
}
*/

//2.Soru

/*
abstract class BankAccount
{
    public string AccountHolder { get; set; } 
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;

    }
    public abstract double CalculateInterest();

}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance) { }
    public override double CalculateInterest()
    {
        return Balance * 0.5;

    }
}
class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance){}
    public override double CalculateInterest()
    {
        Console.WriteLine("Checking acounts do not earn interest! ");
        return 0;
    }
}
*/

//5.Soru

//Abstract Örneği

/*
abstract class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;

    }
    public abstract double CalculateInterest();

}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance) { }
    public override double CalculateInterest()
    {
        return Balance * 0.5;

    }
}
class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance) { }
    public override double CalculateInterest()
    {
        Console.WriteLine("Checking acounts do not earn interest! ");
        return 0;
    }
}
*/

//interface Örneği

/*
interface IShape
{
    void Draw();
    void ChangeColor(Color color);
}
class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Color Color { get; set; }
    public void Draw()
    {
       
        Console.WriteLine("Rectangle drawn.");
    }
    public void ChangeColor(Color color)
    {
        Color = color;
        Console.WriteLine("Rectangle color changed to {0}.", color);
    }
}
*/