using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    public class Teacher : Person
    {
        public string TitleofPerson { get; set; }
        public int WorkingYear { get; set; }
        public string Department { get; set; }

        public Teacher(string firstName, string lastName, string titleofPerson, int workingYear, string department) : base(firstName, lastName)
        {
            TitleofPerson = titleofPerson;
            WorkingYear = workingYear;
            Department = department;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Title Of Person: " + TitleofPerson + "\nWorking Year: " + WorkingYear + "\nDepartment: " + Department);
        }

    }
}
