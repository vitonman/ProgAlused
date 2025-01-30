namespace numberreverse4loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j, rows, counter=1;

            Console.WriteLine("Hello, World!: ");

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++) {
                
                for(j = 1; j <= i; j++) {
                    
                    if (i < 10)
                    {
                        
                        Console.Write(counter++ + " ");


                    }
                    else
                    {
                        Console.Write(counter++ + " ");
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
