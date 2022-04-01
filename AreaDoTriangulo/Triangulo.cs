using System;
namespace AreaDoTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalculaAreaDoTriangulo()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}
