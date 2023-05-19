class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadendo For\n");

        //for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        //{
        //    for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
        //    {
        //        Console.Write("*");
        //        if (contadorColunas >= contadorLinhas)
        //            break;
        //    }

        //    Console.WriteLine();
        //}

        //for (int i = 1; i < 100; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //for (int i = 3; i < 100; i += 3)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        //{
        //    for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
        //    {
        //        Console.Write("*");

        //    }

        //    Console.WriteLine();
        //}

        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " é igual a:  " + fatorial);
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}





