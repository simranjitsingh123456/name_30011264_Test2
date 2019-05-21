/*
 Name = Simranjit Singh
 Student Id = 30011264
 Test = 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the staff payroll system\n " +
                "enter 1. to display Salary\n" +
                "enter 2. to display wages\n");
            //Obtain the information about the employee .
            Console.Write("Your salary is set at 80000 per year\n");
            string salary = Console.ReadLine();
            Console.Write("your salary per week is $1538\n");
            string wages = Console.ReadLine();
            
            //Create an employee object using the constructor employees info.
            Salary p1 = new Salary(salary, wages);

            //Display the info back to the user using the empoyee object. 
            Console.WriteLine($"I will calaculate your wages");
            Console.WriteLine("Enter the number of hours worked" );
            Console.WriteLine("your wages per week is ");
        }
    }

    class Salary
    {
        //2 auto properties
        public string annualsalary {  get; set; }
        public string weeklywages { get; set; }
        

        //Constructor class name.
        public Salary(string _annualsalary, string _weeklywages)
        {
            string Salary = _annualsalary;
            string Wages = _weeklywages;
        }

       
    }

    class Wages
    {
        private int numhours;

        //3 auto properties.
        public string hourlyRate { get; set; }
        public string numHours { get; set; }
        public string weeklywages { get; set; }


        //Constructor class name.
        public Wages(string _hourlyRate, string _numHours, string _weeklywages)
        {
            string Salary = _hourlyRate;
            string Wages = _weeklywages;
        }

        //Method to claculate the employees salary
        public double Net()
        {
            int wages = 0;
            return wages * (33 * numhours );
        }

    }
}