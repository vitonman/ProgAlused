namespace RingCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub reng. Ringi raadius on 3.
            //Leia ja väljasta ekraanile ruudu pindala ja ruudu ümbermõõt

            Console.WriteLine("Sisesta palun raadius: ");

            string r = Console.ReadLine();

            double d = double.Parse(r); // diametr

            double ruutS = d * d; 
            double ruutP = d + d + d + d;

            Console.WriteLine("Ruudu S: " + ruutS);
            Console.WriteLine("Ruudu P: " + ruutP);

            //ringi pindala, ringi ümbermõõt

            Console.WriteLine("Ringi pindala: " + Math.PI * (d));
            Console.WriteLine("Ringi ümbermõõt: " + 2 * Math.PI + r);





        }
    }
}
