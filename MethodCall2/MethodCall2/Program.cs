namespace MethodCall2
{
    internal class Program
    {

        static bool paarisarvCheck(int number)
        {
            if ((number%2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kas number on paaris või paaritu?");

            int number = Int32.Parse(Console.ReadLine());

            //check and call method
            bool checkedNumber = paarisarvCheck(number);
            
            if(checkedNumber == false)
            {
                Console.WriteLine("number on paaritu");
            }
            else
            {
                Console.WriteLine("number on paaris");
            }

        }
    }
}
