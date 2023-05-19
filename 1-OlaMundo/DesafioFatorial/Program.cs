class Programa
{
    static void Main(string[] args)
    {
        int fatorial = 1;

        Console.WriteLine("Desáfio fatorial\n");

        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " é igual a:  " + fatorial);
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();

    }

}



