using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Tester
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var age = int.Parse(input[1]);

                
                var person = new Person(age,name);
                family.AddMember(person);
            }

            foreach (var person in family.SelectedPersons())
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
