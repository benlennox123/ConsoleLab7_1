using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7_1
{
    class Lab7_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сравниваемых треугольников - ");
            int N = Convert.ToInt32(Console.ReadLine());
            double R = 0; ;
            int t = 1;
            int g = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Длина стороны А {0}-го треугольника - ", t);
                double A = Convert.ToDouble(Console.ReadLine());
                Console.Write("Длина стороны B {0}-го треугольника - ", t);
                double B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Длина стороны C {0}-го треугольника - ", t);
                double C = Convert.ToDouble(Console.ReadLine());
                double S = PloshadTreugol(A, B, C);
                if (S!=0)
                {
                    Console.WriteLine("Площадь {0}-го треугольника = {1:f4} ", t, S);
                }
                if (S>R)
                {
                    R = S;
                    g = t;
                }
                t++;
            }
            if (R>0)
            {
                Console.WriteLine("{0}-й треугольник с площадью = {1:f4} - самый большой", g, R);
            }
            else
            {
                Console.WriteLine("Треугольников нет");
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        static double PloshadTreugol(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            if (A+B>C && A+C>B && B+C>A)
            {
                double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return S;
            }
            else
            {
                Console.WriteLine("Такого треугольника не бывает");
                return 0;
            }
        }
    }
}
