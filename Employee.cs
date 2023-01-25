using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Employee // base class / parent class
    {
        protected int id;
        protected string name;
        protected double basic, bonus, gross;
        private static int count;
        public Employee(string name, double basic)
        {
            count++;
            id = count;
            this.name = name;
            this.basic = basic;
        }

        public virtual void CalculateSalary()
        {
            bonus = basic * 0.5;
            gross = basic + bonus;
        }
        public override string ToString()
        {
            return $"\n Id ={id} \n Name ={name} \n Basic Salary ={basic} \n Gross of Employee ={gross}";
        }
    }

    public class SalesPerson : Employee   // imheritance --> child class and derived class 
    {
        private double comm, bonus ;


        // base keyword will call the base class constructor


        public SalesPerson(string name, double basic) : base(name, basic)
        {

        }
        public override void CalculateSalary()
        {
           
            comm = basic * 0.05;
            bonus = basic * 0.5;

           
            gross = basic + comm + bonus;

        }
        public override string ToString()
        {
            return $"\n Id ={id} \n Name ={name} \n Basic Salary ={basic} \n SalesPerson ={gross}";
        }
    }

}




