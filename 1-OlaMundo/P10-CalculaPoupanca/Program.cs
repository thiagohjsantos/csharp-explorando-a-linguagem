class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula poupança\n");

        double investimento = 1000;
        int mes = 1;

        // Rendimento de 0,5% (0.005) ao mês.

        //investimento = investimento + investimento * 0.005;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$: " + investimento);

            mes += 1;
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}





