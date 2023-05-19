class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;
        idade = 27;

        Console.WriteLine("\nMinha idade é: " + idade);

        idade = 27 - 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;

        Console.WriteLine("\nIdade: " + idade);

        idade = (5 - 2) * 3;

        Console.WriteLine("\nIdade: " + idade);

        Console.WriteLine($"\nIdade: {idade}");
        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}


