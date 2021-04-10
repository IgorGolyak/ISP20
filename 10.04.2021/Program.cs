using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.15 б
            Console.WriteLine("Введите числj a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());

            double a2 = a / (b * c);
            Console.WriteLine("Ответ" + a2);
            Console.ReadKey();
        }
    }
}
