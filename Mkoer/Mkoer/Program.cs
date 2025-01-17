namespace Mkoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auh auh, olen tark koer Auh.");
            Console.WriteLine();
            Console.WriteLine("Sisestage esimene arv: ");
            string firstArvSt = Console.ReadLine();
            int firstArvInteger = int.Parse(firstArvSt);

            Console.WriteLine("Sisestage teine arv: ");
            string secondArvSt = Console.ReadLine();
            int secondArvInteger = int.Parse(secondArvSt);

            Console.WriteLine("firstarv = " + firstArvInteger + ", secondArv = " + secondArvInteger);

            Console.WriteLine("Sisestage tehe: ");
            Console.WriteLine("____________________________");
            Console.WriteLine();
            Console.WriteLine("Matematics start!");
            Console.WriteLine();
            Console.WriteLine("Palun valige tehe number:");
                Console.WriteLine("Lahutamine -> - 1");
                Console.WriteLine("Liitumine -> - 2");
                Console.WriteLine("Korrutamine -> - 3");
                Console.WriteLine("Jagamine -> - 4");
            string teheArvString = Console.ReadLine();
            int teheArvInteger = int.Parse(teheArvString);
   
            switch (teheArvInteger)
            {


                case 1:
                    Console.WriteLine("answer is: " + Lahutamine(firstArvInteger, secondArvInteger));
                    Bark(Lahutamine(firstArvInteger, secondArvInteger));
                    break;
                case 2:
                    Console.WriteLine("answer is: " + Liitumine(firstArvInteger, secondArvInteger));
                    Bark(Liitumine(firstArvInteger, secondArvInteger));
                    break;
                case 3:
                    Console.WriteLine("answer is: " + Korrutamine(firstArvInteger, secondArvInteger));
                    Bark(Korrutamine(firstArvInteger, secondArvInteger));
                    break;
                case 4:
                    Console.WriteLine("answer is: " + Jagamine(firstArvInteger, secondArvInteger));
                    Bark(Jagamine(firstArvInteger, secondArvInteger));
                    break;
                default:
                    Console.WriteLine("No information. Error");
                    break;
            }

            Console.WriteLine();
        }

        public static int Lahutamine(int arv1, int arv2)
        {
            int answer = arv1 - arv2;
            return answer; 
        }
        public static int Liitumine(int arv1, int arv2)
        {
            int answer = arv1 + arv2;
            return answer;
        }
        public static int Korrutamine(int arv1, int arv2)
        {
            int answer = arv1 * arv2;
            return answer;
        }
        public static int Jagamine(int arv1, int arv2)
        {
            int answer = arv1 / arv2;
            return answer;
        }

        public static void Bark(int times)
        {
            if (times <= 0)
            {
                Console.WriteLine("no bark for you. sorry.");
            }

            for (int i = 0; i < times; i++)
            {
                Console.Write("bark ");
            }
        }


    }
}
