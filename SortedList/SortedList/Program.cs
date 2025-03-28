using System.Threading.Channels;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted list.");


            SortedList<int, string> numbrid = new SortedList<int, string>()
            {
                {3, "Three"},
                {5, "Five"},
                {1, "One"}
            };

            Console.WriteLine("Algne key value");
            foreach(KeyValuePair<int, string> pair in numbrid)
            {
                Console.WriteLine("Key: {0}, value: {1}", pair.Key, pair.Value);
            }

            //tehke sortedList, kus linnad ja kasutate kahte stringi.

            Console.WriteLine("================================================");
            SortedList<string, string> linnad = new SortedList<string, string>()
            {
                {"Tallinn", "Estonia"},
                {"Riia", "Latvia"},
                {"Vilnus", "Leedu"}
            };

            foreach(KeyValuePair<string, string> pair in linnad)
            {
                Console.WriteLine("Key: {0}, value: {1}", pair.Key, pair.Value);
            }


            linnad.Add("Madrid", "Spain");
            linnad.Add("London", "UK");

            Console.WriteLine("================================================");

            foreach (KeyValuePair<string, string> pair in linnad)
            {
                Console.WriteLine("Key: {0}, value: {1}", pair.Key, pair.Value);
            }

        }


        
    }
}
