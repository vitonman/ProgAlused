namespace stringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] animalNames = {"Koer", "Kass", "Jänes", "Sipelgaslovi", "Lendorav"};

            string rohkemTahedAnimal = "";
            string vaiksemTahedAnimal = "";

     
            for(int i = 0; i < animalNames.Length; i++)
            {
                Console.WriteLine(animalNames[i] + " - " + animalNames[i].Length);
                rohkemTahedAnimal = animalNames[i];
                vaiksemTahedAnimal = animalNames[i];

                for(int j = 0; j < animalNames.Length; j++)
                {
                    
                      
                    if(animalNames[j].Length > rohkemTahedAnimal.Length)
                    {
                        rohkemTahedAnimal = animalNames[j];
                    }

                    if (animalNames[j].Length < vaiksemTahedAnimal.Length)
                    {
                        vaiksemTahedAnimal = animalNames[j];
                    }


                }
            }
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine(rohkemTahedAnimal + " rohkem tahed - " + rohkemTahedAnimal.Length);
            Console.WriteLine(vaiksemTahedAnimal + " vahem tahed - " + vaiksemTahedAnimal.Length);

            //Console.WriteLine(animalName[0] + " TEST TEST");



        }


    }
}
