namespace whileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("While and DO");

            int number = 1;

            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number !< 6);
        }
    }
}
