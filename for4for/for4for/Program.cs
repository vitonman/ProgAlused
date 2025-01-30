using System.Data;

namespace for4for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
        
                for (int j = 0; j< rows; j++) {

                    Console.Write("{0} ");

                }
                Console.Write("\n");
            }
        }
    }
}
