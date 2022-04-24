using System;

public class MainClass
{
    public static void Main()
    {
        Person p = new Person();
	p.Name = "developer-onizuka";
	p.Age = 25;
        p.ActualAge(10);
	Console.WriteLine("Name: " + p.Name);
	Console.WriteLine("Age: " + p.Age);
    }
}

