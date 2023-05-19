class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo\n");

        int idade = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textAdicional;

        if (acompanhado)
            textAdicional = "Fulano está acompanhado.";
        else
            textAdicional = "Fulano não está acompanhado.";

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine(textAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }

}


