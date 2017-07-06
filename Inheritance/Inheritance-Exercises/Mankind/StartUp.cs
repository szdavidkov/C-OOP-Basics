using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var readStudentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var readWorkerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var student  = new Student(readStudentInfo[0],readStudentInfo[1],readStudentInfo[2]);
                var worker = new Worker(readWorkerInfo[0],readWorkerInfo[1],double.Parse(readWorkerInfo[2]),double.Parse(readWorkerInfo[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
