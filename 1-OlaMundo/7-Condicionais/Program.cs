class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais\n");

        int idade = 16;
        int quantidadePessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            else
                Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}


