using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Examples_Oct_021224.Emp_Bonus
{
    public class Employee
    {
        public int basic_salary { get; set; }// read-write property
                                             // public float bonus { set; get; }//read only property
        protected float bonus;
        virtual public void CalculateBonus()
        {
            bonus = 33;
        }
    }
    public class Manager:Employee
    {
        override public void CalculateBonus()
        {
            bonus = basic_salary * 15 / 100f;
        }
        public void showSalary()
        {
            Console.WriteLine("Manager: Basic Salary :"+basic_salary);
            Console.WriteLine("Bonus:"+bonus);
        }
    }
    public class Developer:Employee
    {
        override public void CalculateBonus()
        {
            bonus = basic_salary * 10 / 100f;
        }
        public void showSalary()
        {
            Console.WriteLine("Developer: Basic Salary :" + basic_salary);
            Console.WriteLine("Bonus:" + bonus);
        }
    }
    internal class Company
    {
        public Company()
        {
            Manager mg = new Manager();
            mg.basic_salary = 40000;
            mg.CalculateBonus();
            mg.showSalary();

            Developer dv = new Developer();
            dv.basic_salary = 25000;
            dv.CalculateBonus();
            dv.showSalary();
        }
    }
}
