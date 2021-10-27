using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate void Circle();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Circle circle1 = Dcircle;
            circle1();
            Circle circle2 = Scircle;
            circle2();
            Circle circle3 = Vcircle;
            circle3();
            Console.ReadKey();
        }
        static void Dcircle()
        {
            Console.Write("Введите значение радиуса окружности - ");
            double R = Convert.ToDouble(Console.ReadLine());
            double D = (double)2 * Math.PI * R;
            Console.WriteLine($"Длина окружности равна - {D:F}");
            Console.WriteLine();
        }
        static void Scircle()
        {
            Console.Write("Введите значение радиуса окружности - ");
            double R = Convert.ToDouble(Console.ReadLine());
            double S = (double)Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь окружности равна - {S:F}");
            Console.WriteLine();
        }
        static void Vcircle()
        {
            Console.Write("Введите значение радиуса окружности - ");
            double R = Convert.ToDouble(Console.ReadLine());
            double V = (double) 4 / 3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Объем шара равен - {V:F}");
            Console.WriteLine();
        }
    }
}
