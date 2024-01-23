using System;
using System.Collections.Generic;
using System.Linq;

namespace linq2heighst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Employee> emp = new List<Employee>()
            {
                new Employee { Id= 1,username="Ali",salary= 6000},
                new Employee { Id= 1,username="Ali",salary= 7000},
                new Employee { Id= 1,username="Ali",salary= 12000},
                new Employee { Id= 1,username="Ali",salary= 10000},
            };

            var v = emp.OrderByDescending(x => x.salary).First();
            Console.Write(v.salary);
            Console.ReadKey();


        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string username { get; set; }
        public int salary { get; set; }


    }
}
