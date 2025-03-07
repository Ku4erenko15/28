using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28
{
    internal class Employee : Person
    {
        string company;
        string job;

       public string Company
        {
            get { return company; }
            set { company = value; }
        }
       public string Job
        {
            get { return job; }    
            set { job = value; }
        }

        public Employee(string name, string surname, int age, string company, string job) : base (name, surname, age) 
        {
            this.Company = company;
            this.Job = job;
        }
        
        new public void Output()
        {
            Console.WriteLine($"{Name}\t{Surname}\t{Age}\t{company}\t{job}");
        }

    }
}
