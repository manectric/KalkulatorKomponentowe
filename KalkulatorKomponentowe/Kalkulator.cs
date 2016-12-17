using System;

namespace Kalkulator
{
    public class Kalkulator : IKalkulator
    {
        public double FirstValue = 0;
        public double SecondValue = 0;
        public NazwaMetody Method;

        public double WykonajObliczenia(double a, double b, NazwaMetody method)
        {
            double returnValue;
            switch (method)
            {
                case NazwaMetody.Dodawanie:
                    returnValue = a + b;
                    break;
                case NazwaMetody.Odejmowanie:
                    returnValue = a - b;
                    break;
                case NazwaMetody.Pomnoz:
                    returnValue = a * b;
                    break;
                case NazwaMetody.Podziel:
                    returnValue = a / b;
                    break;
                case NazwaMetody.Pierwiastek:
                    returnValue = Math.Sqrt(a);
                    break;
                default:
                    returnValue = 0;
                    break;
            }
            return returnValue;
        }
    }
}
