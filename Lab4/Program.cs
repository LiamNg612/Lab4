using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEq q = new QuadraticEq(2, 4, 2);
            Console.WriteLine("d = {0}", q.Discriminant);
            double[] results = q.GetRealRoots();
            foreach (double x in results)
                Console.WriteLine(x);
            Console.WriteLine("Equation is {0}", q);

        }
    }
    class QuadraticEq
    {
        int a = 0, b = 0, c = 0;
        double disc, x1, x2;

        public QuadraticEq(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            disc = b * b - 4 * a * c;
        }
        public double Discriminant
        {
            get { return disc; }
        }
        public double[] GetRealRoots()
        {

            double[] arr = { };
            if (disc == 0)
            {
                x1 = -b / (2.0 * a);
                double[] arr1 = { x1 };
                return arr1;
            }
            else if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                double[] arr1 = { x1, x2 };
                return arr1;
            }
            else return arr;
        }
        public override string ToString()
        {
            return a + "x^2+" + b + "x+" + c;
        }

    }
}
