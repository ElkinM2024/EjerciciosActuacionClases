using System;

public abstract class Figura
{
    public abstract double Area();
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double Area()
    {
        return Math.PI * Radio * Radio;
    }
}

public class Rectangulo : Figura
{
    public double Alto { get; set; }
    public double Ancho { get; set; }

    public override double Area()
    {
        return Alto * Ancho;
    }
}

class Program
{
    static void Main()
    {
        Figura figura1 = new Circulo() { Radio = 5 };
        Figura figura2 = new Rectangulo() { Alto = 4, Ancho = 6 };

        Console.WriteLine($"Área del círculo: {figura1.Area()}");
        Console.WriteLine($"Área del rectángulo: {figura2.Area()}");
    }
}
