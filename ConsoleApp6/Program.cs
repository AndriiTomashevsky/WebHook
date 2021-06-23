using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Display()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
    {
        Company = company;
    }
    public new void Display()
    {
        Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
    }
}

abstract class A
{
    public virtual string Print() { return "A"; }
}

class B : A
{
    public virtual new string Print() { return "B"; }
}

class C : B
{
    public virtual new string Print() { return "C"; }
}

class D : C
{
    public override string Print() { return "D"; }
}

class Program
{
    static void Main(string[] args)
    {

        A a = new D();

        Console.WriteLine(a.Print());
    }
}

