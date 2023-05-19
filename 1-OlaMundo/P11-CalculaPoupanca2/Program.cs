class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula poupança, parte 2\n");

        double investimento = 1000;
        //int mes = 12;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$: " + investimento);
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}





