namespace MultiplaSwitchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string topic, category;

            string names = Console.ReadLine();

            switch (names)
            {
                case "Intro to C#":
                case "Variables":
                case "Data types":

                    category = "Basic";
                    break;

                case "Loops":
                case "If statements":
                case "Jump statements":

                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructions":

                    category = "OOP-s concept";
                    break;

                default:
                    category = "UNKNOWN";
                    break;
                
            }

            Console.WriteLine(category);

        }
    }
}
