namespace maslou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            numberPyramid(5);

        }

        static void numberPyramid(int rows)
        {
            int i, j;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows-1; j++)
                {

                    Console.Write(" ");
                }
                for (g = 1; g <= i; g++)
                {

                    Console.Write();
                }

            }
        }
    }


}


