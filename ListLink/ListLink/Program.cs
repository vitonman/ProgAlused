using System.Collections.Immutable;
using System.Data.Common;
using System.Globalization;
using System.Security.Cryptography;

namespace ListLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IList<Person> persons
                = new List<Person>();
            persons.Add(new(1, "juku", 22));
            persons.Add(new(2, "name", 33));
            persons.Add(new(2, "name", 33));
            persons.Add(new(2, "name", 33));

            //var persons = from s in list
            //              select new
            //              {
            //                  Id = s.Id,
            //                  Name = s.Name,
            //                  Age = s.Age,
            //              };

           foreach(var person in persons)
            {
                Console.WriteLine("=================");
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Name);
                Console.WriteLine("=================");
            }

            Console.WriteLine("=======================4==========================");

            for (int i = 0; i < 4; i++)
            {

                Person person = persons[i];
                Console.WriteLine("=================");
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Name);
                Console.WriteLine("=================");
            }

            var personsOrderedBy = persons
                .Where(x => x.Id == 1 || x.Age == 9)
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    Id = x.Id,
                    Age = x.Age,
                    Name = x.Name,
                });

            foreach (var item in personsOrderedBy)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }


            var groupByEl = persons
                .GroupBy(x => x.Id);

            foreach(var item in groupByEl)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }


        }
    }
}
