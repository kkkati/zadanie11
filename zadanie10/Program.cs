using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie uravn = new Uravnenie(25.5, 31.7);
            double x = uravn.Root();
            Console.WriteLine("Корень уравнения 0={0}x+{1} равен {2}", uravn.k, uravn.b, x);
            Console.ReadKey();
        }


        //структура уравнения
        public struct Uravnenie
        {
            public double k;
            public double b;

             //конструктор инициализации переменных
            public Uravnenie (double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            //метод расчета корня уравнения
            public double Root()
            {
                double x = b / k;
                return x;
            }

        }
    }
}
