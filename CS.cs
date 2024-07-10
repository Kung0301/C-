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
    /*class Loop
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Hello");
                i = i++;
            }

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Hello" + x);
            }
            
            int count = 0;
            do
            {
                Console.WriteLine("Hello" + count);
                count++;
            }
            while (count < 10);
        }
    }*/
    class Array
    {
        static void Main(string[] args)
        {
            /*int[] ages = {18,12,15,14,16,28,32,89};
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(ages[i]);
            }

            foreach(int data in ages)
            {
                Console.WriteLine(data);
            }*/

            string[][] users = new string[3][];
            for(int i = 0; i < 1; i++)
            {
                users[i] = new string[3];
                Console.WriteLine("Name :");
                users[i][0] = Console.ReadLine();
                Console.WriteLine("Lastname :");
                users[i][1] = Console.ReadLine();
                Console.WriteLine("Nickname :");
                users[i][2] = Console.ReadLine();
            }
            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine(users[i][0]+" "+users[i][1]+" "+users[i][2]);
            }
        }
    }
}