using System.Globalization;

namespace ForEachList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ForEach List");

            var numbers = new List<int>() {5, -8, 3, 15, 9, 17, 0, 4 };
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Sum {0}", sum);
            Console.WriteLine();
        }
    }
}
