using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Globalization;

namespace teineUlesanne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Millist kujundid soovid?");
            Console.WriteLine("1. ruut");
            Console.WriteLine("2. kolmnurk");
            Console.WriteLine("3. teemant");
            Console.WriteLine("4. ristkylik");
            Console.WriteLine("SISESTA TÄHTEGA!");
            Console.WriteLine();

            string vastus = Console.ReadLine();
            int pikkus;
            int laius; //shirina
            switch (vastus) {
                case "ruut":
                    Console.WriteLine("RUUT");
                    Console.WriteLine("Sisesta ruut pikkud: ");
                    pikkus = int.Parse(Console.ReadLine());
                    ruutCall(pikkus);
                    pikkus = 0;
                    break;

                case "kolmnurk":
                    Console.WriteLine("Sisesta kolmnurk pikkud: ");
                    pikkus = int.Parse(Console.ReadLine());
                    kolmnurkCall(pikkus);
                    pikkus = 0;
                    break;

                case "teemant":
                    Console.WriteLine("Sisesta kolmnurk pikkud: ");
                    pikkus = int.Parse(Console.ReadLine());
                    teemantCall(pikkus);
                    pikkus = 0;
                    break;

                case "ristkylik":
                    Console.WriteLine("Siseste pikkus: ");
                    pikkus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Siseste laius: ");
                    laius = int.Parse(Console.ReadLine());
                    ristkulikCall(laius, pikkus);
                    laius = 0;
                    pikkus = 0;
                    break;
                default:
                    Console.WriteLine("Ei ole sellist figure!");
                    break;
            }

        }

        public static void ruutCall(int size)
        {
            int vastus_S;
            int vastus_P;
            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }

            vastus_S = size * size;
            vastus_P = (size + size) * 2;

            Console.WriteLine("ristkylik pindala on - " + vastus_S + " ja ümbermõõt on - " + vastus_P);
        }

        public static void kolmnurkCall(int size)
        {
            int a = 0;
            int vastus_S;
            int vastus_P;
            for(int i =1; i<= size; i++)
            {
                Console.Write(new string(' ', size - i));
                Console.WriteLine(new string('*', 2 * i - 1));
                if(i == size)
                {
                    a = 2 * i - 1;
                    
                }
            }
            vastus_S = (a * size) / 2;
            vastus_P = size + size + a;
            Console.WriteLine(a + " - number what i need (donts on bottom) ehk alus");
            Console.WriteLine("Kolmnurk pindala on - " + vastus_S + " ja ümbermõõt on - " + vastus_P);

        }

        public static void teemantCall(int size)
        {
            int a = 0;
            int vastus_S;
            int vastus_P;

            for (int i = 1; i <= size; i++)
            {
                Console.Write(new string(' ', size - i));
                Console.WriteLine(new string('*', 2 * i - 1));
                if (i == size)
                {
                    a = 2 * i - 1;
                }
            }
            for (int i = size - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', size - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }

            vastus_S = (a * size / 2) * 2;
            vastus_P = size * 4;
            Console.WriteLine("Teemant pindala on - " + vastus_S + " ja ümbermõõt on - " + vastus_P);
        }

        public static void ristkulikCall(int laius, int pikkus)
        {
            int vastus_S;
            int vastus_P;
            for (int row = 1; row <= pikkus; row++)
            {
                for (int column = 1; column <= laius; column++)
                {
                    string mark;
                    if (row == column)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }

            vastus_S = laius * pikkus;
            vastus_P = (laius + pikkus)*2;

            Console.WriteLine("Ristkülik pindala on - " + vastus_S + " ja ümbermõõt on - " + vastus_P);
        }
    }
}
