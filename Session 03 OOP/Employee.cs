using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_OOP
{
    public class Employee
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }
        public SecurityLevel Security { get; set; }
        public decimal Salary;
        public DateTime HireDate { get; set; }

        // Constructor
        public Employee(int id, string name, char gender, SecurityLevel security, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        // Overridden ToString method
        public override string ToString()
        {
            return $" ID: {ID}\n Name: {Name}\n Gender: {Gender}\n Security Level: {Security}\n Salary: {Salary} \n Hire Date: {HireDate}";
        }
    }

}
