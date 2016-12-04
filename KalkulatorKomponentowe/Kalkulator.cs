using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalkulator : IKalkulator
    {
        public enum NazwaMetody
        {
            Dodawanie = 1,
            Odejmowanie = 2,
            Pomnoz = 3,
            Podziel = 4,
            Pierwiastek = 5
        }

        public double Dodaj(double a, double b)
        {
            return a + b;
        }

        public double Odejmij(double a, double b)
        {
            return a - b;
        }

        public double Pierwiastek(double a)
        {
            return Math.Sqrt(a);
        }

        public double Podziel(double a, double b)
        {
            return a/b;
        }

        public double Pomnoz(double a, double b)
        {
            return a*b;
        }
    }
}
