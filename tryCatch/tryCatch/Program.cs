namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //peab sisestama numbrit 1 või 2
              
            string string_Arv = Console.ReadLine();
            int int_arv = int.Parse(string_Arv);

            try
            {
                switch (int_arv)
                {
                    case 1:
                        Console.WriteLine("1 - korras");
                        break;
                    case 2:
                        Console.WriteLine("2 - korras");
                        break;
                    
                } 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ei sisestanud numbi formaati");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur");
            }
        }
    }
}
