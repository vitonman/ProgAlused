namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string transportValimine_string = Console.ReadLine();
            int transportChoose = int.Parse(transportValimine_string);

            Console.WriteLine("Choose your transport:");

            Console.WriteLine("1- coupe");
            Console.WriteLine("2- truck");
            Console.WriteLine("3- bus");

            switch (transportChoose)
            {
                case 1:
                    coupeTransport();
                    break;
                case 2:
                    truckTransport();
                    break;
                case 3:
                    busTransport();
                    break;
                default:
                    Console.WriteLine("No such transport in list");
                    break;
            }

        }


        private static void coupeTransport()
        {
            Console.WriteLine("This is coupe");
        }

        private static void truckTransport()
        {
            Console.WriteLine("truck transport");
        } 
        private static void busTransport()
        {
            Console.WriteLine("bus transport");
        }
    }
}
