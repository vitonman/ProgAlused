namespace CoffeePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Spundi kohvik!");
            Console.WriteLine("\n\nMenü (kohvi valik)\n\n");
            Console.WriteLine("1. Väike tass");
            Console.WriteLine("2. Keskmine tass");
            Console.WriteLine("3. Suur tass");
            Console.WriteLine("\n\nPalun tee oma valik\n\n");

            byte coffeSize = byte.Parse(Console.ReadLine());

            double price = 0;

            switch (coffeSize)
            {
                case 1:
                    price = 1.5;
                    break;
                case 2:
                    price = 2.5;
                    break;
                case 3:
                    price = 3;
                    break;
            }

            Console.
                WriteLine(price);
        }
    }
}
