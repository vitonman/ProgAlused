namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Coordinate point = new Coordinate(10, 20);
            Console.WriteLine(point.X + ":X ; " + point.Y + ":Y");
            point.Equals(new Coordinate(10, 20));

            IntAndString IntAndstr = new IntAndString(23, "vitja");
        }

        struct Coordinate
        {
            public int X;
            public int Y;

            public Coordinate(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }


        struct IntAndString
        {
            public int age;
            public string name;

            public IntAndString(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
    }
}
