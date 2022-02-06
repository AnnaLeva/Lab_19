using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Num=1, Name="Иванов", Summa = 100, City="Moscow"},
                new Employee() {Num=2, Name="Петров", Summa = 110, City="Санкт-Петрбург"},
                new Employee() {Num=3, Name="Сидоров", Summa = 60, City="Сочи"},
                new Employee() {Num=4, Name="Кузнецов", Summa = 200, City="Иркутс"},
                new Employee() {Num=5, Name="Васильев", Summa = 150, City="Москва"},
                new Employee() {Num=6, Name="Вороьбьев", Summa = 300, City="Сочи"},
                new Employee() {Num=7, Name="Балаганов", Summa = 500, City="Москва"},
                new Employee() {Num=8, Name="Бендр", Summa = 800, City="Екатеринбург"}
            };
            //Console.WriteLine("Введите город");
            //string city = Console.ReadLine();
            //List<Employee> employees1 = employees.Where(x => x.City == city).ToList();
            //Print(employees1);

            //Console.WriteLine("Введите сумму");
            //int summa = Convert.ToInt32(Console.ReadLine());
            //List<Employee> employees2 = employees.Where(x => x.Summa >= summa).ToList();
            //Print(employees2);

            //List<Employee> employees3 = employees.OrderBy(x => x.Name).ToList();
            //Print(employees3);

            //IEnumerable<IGrouping<String, Employee>> employees4 = employees.GroupBy(x => x.City);
            //foreach (IGrouping < String, Employee> gr  in employees4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach (Employee e in gr)
            //    {
            //    Console.WriteLine($"{e.Num} {e.Name} {e.City}");
            //    }
            //}

            //Employee employee5 = employees.OrderByDescending(x => x.Summa).FirstOrDefault();
            //Console.WriteLine($"{employee5.Num} {employee5.Name} {employee5.City}");

            Console.WriteLine(employees.Any(x => x.Summa>150));



            Console.ReadKey();
        }

        static void Print(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{e.Num} {e.Name} {e.City}");
            }
            Console.WriteLine();
        }
    }

    class Employee
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }
        public string City { get; set; }
    }
}
