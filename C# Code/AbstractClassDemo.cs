using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{

    #region "Interface "
    interface ICustomer01
    {
        void Print();
    }

    interface ICustomer02 
    {
        void Print();
    }

    public abstract class Customer01
    {
        public abstract void Print();    
    }
    public abstract class Customer02 : Customer01
    {
        public override abstract void Print();
    }

    #endregion



    public delegate void HelloDelegate(string str);

    class Program
    {
        //public static void Hello(string strmsg)
        //{
        //    Console.WriteLine(strmsg);
        //}

        static void Main(string[] args)
        {
            //HelloDelegate del = new HelloDelegate(Hello);
            //del("Welcome to delegate program");

            List<Employee> empVal = new List<Employee>();
            empVal.Add(new Employee { ID = 101, Name = "Asif", Salary = 5000, Experience= 5 });
            empVal.Add(new Employee { ID = 102, Name = "Ali", Salary = 6000, Experience = 6 });
            empVal.Add(new Employee { ID = 103, Name = "Asma", Salary = 7000, Experience = 7 });
            empVal.Add(new Employee { ID = 104, Name = "Raja", Salary = 4000, Experience = 4 });
            empVal.Add(new Employee { ID = 105, Name = "Jhon", Salary = 3000, Experience = 3 });

            Employee.Promoted(empVal, e=>e.Salary>=5000);
            //Console.ReadKey();
        }

        
    }

    public delegate bool IsPromotion(Employee emp);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promoted(List<Employee> emp, IsPromotion isPromoted)
        {
            foreach (Employee e in emp)
            {
                if (isPromoted(e))
                {
                    Console.WriteLine(e.Name + " has been Promoted!");
                }
            }
        }
    }
}
