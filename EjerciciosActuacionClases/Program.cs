using System;

public class Coche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public string Color { get; set; }

    public void Encender()
    {
        Console.WriteLine("El coche ha sido encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El coche ha sido apagado.");
    }

    public void Informacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Color: {Color}");
    }
}

class Program
{
    static void Main()
    {
        Coche coche1 = new Coche() { Marca = "Toyota", Modelo = "Corolla", Año = 2020, Color = "Rojo" };
        coche1.Informacion();
        coche1.Encender();
        coche1.Apagar();
    }
}

