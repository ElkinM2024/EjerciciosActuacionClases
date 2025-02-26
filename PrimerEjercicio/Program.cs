using System;

public class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especie { get; set; }

    public virtual void Hablar()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

public class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El perro ladra");
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro() { Nombre = "Rex", Edad = 3, Especie = "Canino" };
        perro.Hablar();
    }
}
