using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tester
{
    static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        var difference= new DateModifier(firstDate,secondDate);
        Console.WriteLine($"{difference.CalculateDifference()}");
    }
}

