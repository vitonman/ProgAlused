namespace PaarPaaritu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            bool answer = true;

            while (answer == true)
            {

                //Paar-Paaritu
                Console.WriteLine("Sisesta number!");

                string nr = Console.ReadLine();
                int number = int.Parse(nr);

                if ((number % 2) == 0)
                {
                    Console.WriteLine(number + " on paar");
                }
                else
                {
                    Console.WriteLine(number + " on paaritu");
                }

                Console.WriteLine("kas veel? kui jah kirjuta 'y' ");
                string answer_repeat = Console.ReadLine();
                if(answer_repeat == "y")
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
                
            }

          
        }
    }
}
