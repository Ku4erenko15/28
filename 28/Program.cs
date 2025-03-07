using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Абабий","Антон", 17);
            person.Output();
            Employee Epm = new Employee("Абабий", "Антон", 17, "Прокуратура","Майор");
            Epm.Output();
            Employee emp = new Employee("Данил", "Кучеренко", 30, "Google", "Программист");

            Person refPerson = emp;
            refPerson.Output(); 
            Employee refEmployee = (Employee)refPerson;
            Console.Write($"Работает в {refEmployee.Company} на должности {refEmployee.Job}");
        


        Console.ReadKey();
        }
    }
}
