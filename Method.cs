namespace Method
{
    public class Method
    {
        public static void sayHelloWorldx10()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
                Console.WriteLine(calculate());
            }
        }
        private static int calculate()
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            return sum;
        }
        private static void cal()
        {
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + "+"+"2"+"="+(number+2));
            Console.WriteLine(number + "-"+"2"+"="+(number-2));
            Console.WriteLine(number + "*"+"2"+"="+(number*2));
            Console.WriteLine(number + "/"+"2"+"="+(number/2));
        }
    }
}