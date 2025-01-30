namespace ForTriangleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;

            Console.WriteLine("Sisesta ridade arv: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if(i < 10)
                    {
                        Console.Write(i + "  ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}