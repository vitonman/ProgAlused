namespace randomSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 0; i<50; i++)
            {
                int rand_number = new Random().Next(1, 7);

                switch (rand_number)
                {
                    case 0:
                        Console.WriteLine("[case:0] Number is " + rand_number);
                        break;
                    case 1:
                        Console.WriteLine("[case:1] Number is " + rand_number);
                        break;
                    case 2:
                        Console.WriteLine("[case:2] Number is " + rand_number);
                        break;
                    case 3:
                        Console.WriteLine("[case:3] Number is " + rand_number);
                        break;
                    case 4:
                        Console.WriteLine("[case:4] Number is " + rand_number);
                        break;
                    case 5:
                        Console.WriteLine("[case:5] Number is " + rand_number);
                        break;
                    case 6:
                        Console.WriteLine("[case:6] Number is " + rand_number);
                        break;
                }
            }

            

        }
       
    }
}
