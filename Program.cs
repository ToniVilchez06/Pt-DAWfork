using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe cotxe1 = new Cotxe("Cooper", "Mini", 2020, 220.0, 5);

        // Mostrar la informació del vehicle
        cotxe1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe cotxe2 = new Cotxe("A3", "Audi", 2006, 210.0, 3);
        
        // Mostrar la informació del segon vehicle
        cotxe2.MostrarInformacio();
    }
}
