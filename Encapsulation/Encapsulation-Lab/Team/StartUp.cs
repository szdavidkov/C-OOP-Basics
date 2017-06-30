using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("Pirin Blagoevgrad");

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var person = new Person(input[0],input[1],int.Parse(input[2]));
                

                team.AddPlayer(person);             
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"First team have {team.ReserveTeam.Count} players");
        }
    }
}
