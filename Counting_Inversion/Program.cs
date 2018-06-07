using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = FileService.ReadFile();

            Brute_Force_algoritm b = new Brute_Force_algoritm();
            Console.WriteLine(b.CountInv(inputList));
            Console.ReadKey();
        }
    }
}
