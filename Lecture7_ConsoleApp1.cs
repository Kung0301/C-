using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine()) + 100;
            Console.WriteLine(firstName + " " + lastName + " " + "Salary :" + " " + salary.ToString() + " " + "THB");
            Console.ReadLine();
        }
    }
}