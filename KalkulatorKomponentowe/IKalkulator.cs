namespace Kalkulator
{
    interface IKalkulator
    {
        double WykonajObliczenia(double a, double b, NazwaMetody method);
    }

    public enum NazwaMetody
    {
        Dodawanie = 1,
        Odejmowanie = 2,
        Pomnoz = 3,
        Podziel = 4,
        Pierwiastek = 5
    }
}
