namespace ifelseagain
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Please enter your age: ");
            string number = Console.ReadLine();

            int age = Int32.Parse(number);

            if (age <= 18 && age! < 1)
            {
                Console.WriteLine("Your age below 18");
            }
            else if (age >= 19 && age <= 65)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("pension");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            {

            }
        }
    }
}
