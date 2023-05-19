class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Desáfio múltiplo\n");

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();

    }

}



