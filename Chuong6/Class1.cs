using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{


    public class Shape
    {

        public virtual void Draw()
        {
            Console.WriteLine("shape");
        }
    }


    //demo

    //tu khoa base
    public class Person() 
    {
        protected string name = "Nguyen Duc Hung";
        protected string sdt = "123456789";
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}" );
            Console.WriteLine($"Sdt:{sdt}" );
        }

    }
    public class Student:Person
    {
        public string id = "rk-255";
        public void ShowInfo()
        {
            base.GetInfo();
            Console.WriteLine($"studentId: {id}");
        }
    }

    public class Employee
    {
        public string name;
        protected decimal salary;

        //constructor
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;

        }
        // phuong thuc ao de overriding
        public virtual decimal CalculatePay()
        {
            return salary;
        }
    }

    public class SalesEmployee : Employee
    {
        private decimal bonus;
        public SalesEmployee(string name, decimal salary, decimal bonus)
            : base(name, salary)
        {
            this.bonus = bonus;
        }
        public override decimal CalculatePay()
        {
            return salary + bonus;
        }
    }
}
