using System;

namespace CS
{
    /*class ConsoleApp1
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
    }*/
    /*class Condition
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score >= 80)
            {
                Console.WriteLine("A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C");
            }
            else if (score  >= 50)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();
        }
    }*/
    class Loop
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Hello");
                i = i++;
            }*/
            /*for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Hello" + x);
            }*/
            int count = 0;
            do
            {
                Console.WriteLine("Hello" + count);
                count++;
            }
            while (count < 10);
        }
    }
}