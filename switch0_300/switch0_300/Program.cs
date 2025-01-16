namespace switch0_300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Sisesta number 0 to 300");

            string stringArv = Console.ReadLine();

            int stringArv_to_int = int.Parse(stringArv);

            switch (stringArv_to_int)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("0-100");
                    break;
                case > 100 and < 200:
                    Console.WriteLine("101-200");
                    break;
                case > 200 and <= 300:
                    Console.WriteLine("201 - 300");
                    break;
                default:
                    Console.WriteLine("Out of range");
                    break;

            }

        }
    }
}
