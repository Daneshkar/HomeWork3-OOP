using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }

        public Student(string name, int age, string studentId, string major)
            : base(name, age)
        {
            StudentID = studentId;
            Major = major;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Student ID: {StudentID}, Major: {Major}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Student Information ===");
            Console.WriteLine(GetDetails());
        }
    }
}
