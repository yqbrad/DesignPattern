using System;

namespace Composit
{
    class Program
    {
        //Compose objects into tree structures to represent part-whole hierarchies.
        //Composite lets clients treat individual objects and compositions of objects uniformly.
        static void Main(string[] _)
        {
            var organ = new Organization();
            organ.AddEmployee(new Developer());
            organ.AddEmployee(new Designer());

            foreach (var employee in organ.GetEmployees)
                Console.WriteLine($"{employee.JobTitle}:{employee.Salary}\n");

            Console.ReadLine();
        }
    }
}