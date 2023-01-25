using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //  Polymorphism: → it is a mechanism in which multiple objects have a same behavior but having different implementation is called polymorphism


            Employee e1 = new Employee("Vivekanand", 17000); //object 1
            e1.CalculateSalary();
            Console.WriteLine(e1);

            SalesPerson m1 = new SalesPerson("Vidyanand", 41000); // object 2
            m1.CalculateSalary();
            Console.WriteLine(m1);
        }

    }
}
