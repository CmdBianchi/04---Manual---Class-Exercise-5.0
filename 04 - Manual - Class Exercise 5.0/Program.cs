using System;
using Entities;
namespace _04___Manual___Class_Exercise_5._0 {
    class Program {
        
        static void Main(string[] args) {
            Calculator calculator = new Calculator();
            Console.Write("Entre o valor do raio: "); double radius = double.Parse(Console.ReadLine());
            double circ = Calculator.Circumference(radius);
            double vol = Calculator.Volume(radius);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F6"));
        }
    }
}
