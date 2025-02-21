using System.Threading.Channels;

namespace ForEachInEveryMay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            List<string> listOfStrings = new List<string>() { "one", "two", "three", "four", "five"};

            int choice;

            Console.WriteLine("Please choose what loop wann to use: ");
            Console.WriteLine("1. ForEach");
            Console.WriteLine("2. ForLoop");
            Console.WriteLine("3. QUIT");
            Console.WriteLine("Enter 1 or 2 :");
            

            bool invalidInput = true;
            while (invalidInput)
            {
                choice = Int32.Parse(Console.ReadLine());

                invalidInput = false;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("USED ForEach: ");
                        ForEachMethod(listOfStrings);
                        Console.WriteLine();
                        invalidInput = true;
                        break;
                    case 2:
                        Console.WriteLine("USED default For cycle: ");
                        ForMethod(listOfStrings);
                        Console.WriteLine();
                        invalidInput = true;
                        break;
                    case 3:
                        Console.WriteLine("QUIT");
                        break;
                    default:
                        Console.WriteLine("No such number! ");
                        invalidInput = true;
                        break;
                }

            }
            Console.WriteLine("Thanks for choosing our software!");

        }


        public static void ForEachMethod(List<string> listOfStrings)
        {
            foreach(string stringWord in listOfStrings)
            {
                Console.WriteLine(stringWord);
            }
        }

        public static void ForMethod(List<string> listOfStrings)
        {
            for(int i = 0; i<listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
            }
        }


    }
}
