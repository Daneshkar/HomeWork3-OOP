using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class University
    {
        public void DisplayAllPeople(Person[] people)
        {
            Console.WriteLine("\n=== Displaying All University People ===");
            foreach (Person person in people)
            {
                person.DisplayInfo();
                Console.WriteLine();
            }
        }

        public void ShowAllDetails(Person[] people)
        {
            Console.WriteLine("\n=== All Details ===");
            foreach (Person person in people)
            {
                Console.WriteLine(person.GetDetails()); 
            }
        }
    }
}
