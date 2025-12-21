using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Professor : Person
    {
        public string ProfessorId { get; set; }
        public string Subject { get; set; }

        public Professor(string name, int age, string professorId, string subject)
            : base(name, age)
        {
            ProfessorId = professorId;
            Subject = subject;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Professor ID: {ProfessorId}, Subject: {Subject}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("=== Professor Information ===");
            Console.WriteLine(GetDetails());
        }
    }
}
