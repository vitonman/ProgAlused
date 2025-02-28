namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik numbriga!");
            Console.WriteLine("");

            Console.WriteLine("1. Sum LINQ");
            Console.WriteLine("2. Max Linq");
            Console.WriteLine("3. Agregat");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SumLINQ();
                    break;
                case "2":
                    MaxLINQ();
                    break;
                case "3":
                    AggregateLINQ();
                    break;
                case "4":
                    minLINQ();
                    break;
                case "5":
                    Skip();
                    break;
                case "6":
                    SkipWhile();
                    break;
                case "7":
                    Take();
                    break;
                case "8":
                    TakeWhile();
                    break;
                case "9":
                    FirstOrDefaultLINQ();
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        public static void SumLINQ()
        {
            //summerib arvud kui tingimus on õige
            var sumAge = PeopleList.people.Sum(x => x.Age);
            Console.WriteLine(sumAge);
            Console.WriteLine("Täisealiste isikute koondarv");
            var sumAdults = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("Täiskasvanute isikute summa on " + sumAdults);
        }

        public static void MaxLINQ()
        {
            //kirjutab alla kõige suurem arv
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Kõige vanem inimene on " + oldestPerson);
        }

        public static void AggregateLINQ()
        {
            //elementide järjestikune töötlemine
            string commaSeparatedPersonsNames = PeopleList.people
                .Aggregate<People, string>(
                "People names: ",
                (str, y) => str += y.Name + ", " 
                );
            Console.WriteLine(commaSeparatedPersonsNames);
        }

        public static void minLINQ()
        {
            //Miinumum arv
            var youngestPerson = PeopleList.people
                .Min(x => x.Age);
            Console.WriteLine("Kõige noorem inimene on " + youngestPerson);
        }

        public static void Skip()
        {
            //skip one person, esimene listis
            var skippedPeoples = PeopleList.people.Skip(1);

            string skippedNamesList = skippedPeoples
               .Aggregate<People, string>(
               "(Skip) People names: ",
               (str, y) => str += y.Name + ", "
               );
            Console.WriteLine(skippedNamesList);
        }

        public static void SkipWhile()
        {
            //skip one person while skipped true skip next
            var skippedPeoples = PeopleList.people.SkipWhile(p =>  p.Age < 40);

            string skippedNamesList = skippedPeoples
               .Aggregate<People, string>(
               "(Skip While) People names: ",
               (str, y) => str += y.Name + ", "
               );
            Console.WriteLine(skippedNamesList);
        }

        public static void Take()
        {

            //võttab ainult nii palju elemendi mis on vaja
            var takeNamesTwo = PeopleList.people.Take(2);

            string skippedNamesList = takeNamesTwo
             .Aggregate<People, string>(
             "(Take) People names: ",
             (str, y) => str += y.Name + ", "
             );
            Console.WriteLine(skippedNamesList);
        }

        public static void TakeWhile()
        {
            //võtab elemendi kui tingimus jookseb
            var takeNamesWhile = PeopleList.people.TakeWhile(p => p.Age <= 40);
            string skippedNamesList = takeNamesWhile
             .Aggregate<People, string>(
             "(Take While) People names: ",
             (str, y) => str += y.Name + ", "
             );
            Console.WriteLine(skippedNamesList);
        }

        public static void FirstOrDefaultLINQ()
        {
            //võtab esimene element või return NULL
            var first = PeopleList.people.FirstOrDefault();
            Console.WriteLine(first.Name);
        }

    }
}
