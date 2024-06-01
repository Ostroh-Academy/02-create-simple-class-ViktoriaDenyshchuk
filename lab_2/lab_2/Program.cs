using System;

namespace QuadraticEquationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new QuadraticEquation();
            equation.InputCoefficients();

            if (equation.HasRealSolutions(out double x1, out double x2))
            {
                Console.WriteLine("Рівняння має дійсні розв'язки:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Рівняння не має дійсних розв'язків.");
            }
        }
    }

    class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public void InputCoefficients()
        {
            Console.Write("Введіть коефіцієнт a: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Введіть коефіцієнт b: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Введіть коефіцієнт c: ");
            C = double.Parse(Console.ReadLine());
        }

        public bool HasRealSolutions(out double x1, out double x2)
        {
            double discriminant = B * B - 4 * A * C;
            if (discriminant >= 0)
            {
                x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                return true;
            }
            else
            {
                x1 = double.NaN;
                x2 = double.NaN;
                return false;
            }
        }
    }
}
