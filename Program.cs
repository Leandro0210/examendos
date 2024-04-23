using System;

// Clase para manejar la interfaz de usuario
public class CalculadoraUI
{
    public void MostrarMenu()
    {
        Console.WriteLine("Bienvenido a la Calculadora de Física:");
        Console.WriteLine("1. Calcular distancia (MRU)");
        Console.WriteLine("2. Calcular velocidad (MRU)");
        Console.WriteLine("3. Calcular tiempo (MRU)");
        Console.WriteLine("4. Calcular posición final (MRUA)");
        Console.WriteLine("5. Calcular velocidad final (MRUA)");
        Console.WriteLine("6. Calcular tiempo (MRUA)");
        Console.WriteLine("7. Salir");
    }

    public void RealizarCalculo(int opcion)
    {
        switch (opcion)
        {
            case 1:
                CalcularDistanciaMRU();
                break;
            case 2:
                CalcularVelocidadMRU();
                break;
            case 3:
                CalcularTiempoMRU();
                break;
            case 4:
                CalcularPosicionFinalMRUA();
                break;
            case 5:
                CalcularVelocidadFinalMRUA();
                break;
            case 6:
                CalcularTiempoMRUA();
                break;
            case 7:
                Console.WriteLine("Saliendo del programa...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                break;
        }
    }
     private void CalcularDistanciaMRU()
    {
        // Implementa el cálculo de distancia para MRU
    }

    private void CalcularVelocidadMRU()
    {
        // Implementa el cálculo de velocidad para MRU
    }

    private void CalcularTiempoMRU()
    {
        // Implementa el cálculo de tiempo para MRU
    }

    private void CalcularPosicionFinalMRUA()
    {
        // Implementa el cálculo de posición final para MRUA
    }

    private void CalcularVelocidadFinalMRUA()
    {
        // Implementa el cálculo de velocidad final para MRUA
    }

    private void CalcularTiempoMRUA()
    {
        // Implementa el cálculo de tiempo para MRUA
    }
}