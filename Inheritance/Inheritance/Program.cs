namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //saab sisestada kaks numbrit

            //kutsu esile Rectangle classi ja suunad kaks väärtust sellesse klassi


            Rectangle re = new();
     

            Console.WriteLine("Palun sisesta height: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisesta width: ");
            int width = Int32.Parse(Console.ReadLine());

            re.setHeight(height);
            re.setWidth(width);
            int area = re.GetArea();

            Console.WriteLine("Sinu height on: " + height + " ja width on: " + width);
            Console.WriteLine("Area on: " + area);


        }
    }


    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}
