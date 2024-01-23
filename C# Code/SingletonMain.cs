using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            Singleton fromStudent = Singleton.GetInstance;
        fromStudent.PrintDetails("From Student");

            Console.ReadLine();
        }
    }
}
