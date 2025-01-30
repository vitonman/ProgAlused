namespace ruudiiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Kas soovid ruut teha? y/n");
            string vastus = Console.ReadLine();

            if(vastus == "y")
            {
                Console.WriteLine("Sisesta ridade arv: ");
                rows = Convert.ToInt32(Console.ReadLine());

                ruutCreator(rows);
            }
            else
            {
                Console.WriteLine("OKAY THEN, BYE");
            }



         

        }


        static void ruutCreator(int rows)
        {
            int i, j;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows; j++)
                {
                        Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
