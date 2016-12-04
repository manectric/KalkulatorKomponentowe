using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    interface IKalkulator
    {

        double Dodaj(double a, double b);

        double Odejmij(double a, double b);

        double Pomnoz(double a, double b);

        double Podziel(double a, double b);

        double Pierwiastek(double a);

    }
}
