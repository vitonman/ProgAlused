using System.Runtime.CompilerServices;

namespace SwitchLeppeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write please a, y or u");


            //rakendus tuleb, et sisesta vokaal
            //3 vokaalist piisab
            //kui vokaal on sisestatud, siis ütleb, et sisestasid selle tähe, kasuta switchi


            const string a = " You pressed a";
            const string y = " You pressed y";
            const string u = " You pressed u";

            string input = Console.ReadLine();

            switch (input)
            {
                case "a": 
                    writeSentence(a);
                    break;

                case "y": 
                    writeSentence(y);
                    break;

                case "u": 
                    writeSentence(u);
                    break;

                default:
                    Console.WriteLine(" You did not type a, u or y");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }


        }
        static void writeSentence(string a)
        {
            Console.WriteLine(a); // correction 3
        }
    }
      
}
