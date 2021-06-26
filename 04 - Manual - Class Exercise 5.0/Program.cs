using System;
using Entities;
namespace _04___Manual___Class_Exercise_5._0 {
    class Program {
        static double Pi = Math.PI;        
        static void Main(string[] args) {
            Console.Write("Entre o valor do raio: "); double radius = double.Parse(Console.ReadLine());
            double circ = Circumference(radius);
            double volume = Volume(radius);
            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F6"));
        }
        static double Circumference(double r) {
            return 2.0 * Pi * r;
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
