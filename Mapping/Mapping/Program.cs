using AutoMapper;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Employee emp = new Employee();

            emp.Id = 11;
            emp.Name = "Name";
            emp.Title = "Title";
            emp.Description = "Description";

            //mapping algab
            //data tranfer object

            EmployeeDto dto = new EmployeeDto();
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " "
                + dto.Title + " " + dto.Description);

            Employee employee = new Employee
            {
                Id = 123,
                Name = "Name",
                Description = "Description",
                Title = "Title",
            };

            var mapper = Program.InitializerAutomapper();

        }

        //Mapper on Automapper nugger saadud class
        public static Mapper InitializerAutomapper()
        {
            var config
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }


}
