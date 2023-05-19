class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Criando Variáveis Ponto Flutuante");

        double salario;
        salario = 3000.10;

        salario = 3000;

        double idade;
        idade = 7.0 / 5;

        //int valor = 12.5; não compila.
        //double valor = 12; compila.

        Console.WriteLine(idade);

        Console.WriteLine("Meu salário é: " + salario);

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();

    }
}


