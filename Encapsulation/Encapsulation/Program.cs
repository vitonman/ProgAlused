using Encapsulation_Service;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapseldamine");

            Student2 student = new Student2();

            Student student2 = new Student();
            student.Id = 101;
            student.Name = "Kyrica";
            student.Email = "Kyrica@kyrica.kuric";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);

            //kasutame protect class
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething(); ei saa et protected

            Program program = new Program();
            program.DoSomethingInProgramClass();

            Program pp = new Program();
            Console.WriteLine(pp.PrivateProtectedInProgramClass 
                = " ProvateProtectedInProgramClass");

        }
        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DosomethingInProgramClass");
        }

        private protected string PrivateProtectedInProgramClass =
            "PrivateProtectedInProgramClass";
    }
}
