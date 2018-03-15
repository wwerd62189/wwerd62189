using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI ;
            Console.Write("身高:" );
            string a = Console.ReadLine();

            Console.Write("體重:");
            string b = Console.ReadLine();

            double c = b / (a / 100) ^ 2;

            string d = Console.ReadLine("BMI:"+c);

            


        }
    }
}
