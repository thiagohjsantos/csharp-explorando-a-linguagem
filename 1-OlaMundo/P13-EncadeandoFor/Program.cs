class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadendo For\n");

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}





