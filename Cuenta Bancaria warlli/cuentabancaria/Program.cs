using System;

class CuentaBancaria
{
    private string titular;
    private decimal saldo;

    // Constructor
    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        this.titular = titular;
        this.saldo = saldoInicial;
    }

    // Método para depositar dinero
    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito exitoso. Nuevo saldo: RD${saldo:F2}");
        }
        else
        {
            Console.WriteLine("Error: El monto debe ser mayor a 0.");
        }
    }

    // Método para retirar dinero
    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Nuevo saldo: RD${saldo:F2}");
        }
        else if (monto > saldo)
        {
            Console.WriteLine("Error: Fondos insuficientes.");
        }
        else
        {
            Console.WriteLine("Error: El monto debe ser mayor a 0.");
        }
    }

    // Método para mostrar información de la cuenta 
    public void MostrarInformacion()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: RD${saldo:F2}");
        Console.WriteLine("-------------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Creando cuentas bancarias
        CuentaBancaria cuenta1 = new CuentaBancaria("Gamalier  Reyes", 19000);
        CuentaBancaria cuenta2 = new CuentaBancaria("Cameron  Cedeño", 15000);
        
        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Mostrar información");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 4) break;

            Console.Write("Seleccione cuenta (1 o 2): ");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            CuentaBancaria cuentaSeleccionada = seleccion == 1 ? cuenta1 : cuenta2;

            if (opcion == 1)
            {
                Console.Write("Ingrese monto a depositar: ");
                decimal monto = Convert.ToDecimal(Console.ReadLine());
                cuentaSeleccionada.Depositar(monto);
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese monto a retirar: ");
                decimal monto = Convert.ToDecimal(Console.ReadLine());
                cuentaSeleccionada.Retirar(monto);
            }
            else if (opcion == 3)
            {
                cuentaSeleccionada.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
