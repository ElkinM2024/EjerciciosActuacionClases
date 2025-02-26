using System;

public class CuentaBancaria
{
    private string titular;
    private decimal saldo;

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public decimal Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Se han depositado {cantidad}.");
        }
        else
        {
            Console.WriteLine("La cantidad debe ser positiva.");
        }
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && saldo >= cantidad)
        {
            saldo -= cantidad;
            Console.WriteLine($"Se han retirado {cantidad}.");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o cantidad inválida.");
        }
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(500);
        cuenta.Retirar(200);
        Console.WriteLine($"Saldo actual: {cuenta.Saldo}");
    }
}
