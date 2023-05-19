class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos\n");

        float pontoFlutuante = 3.14f;

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long é um tipo de variável de 64 bits.
        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.67f;
        Console.WriteLine(altura);

        double valor1 = 0.2;
        double valor2 = 0.1;
        double total = valor1 + valor2;

        Console.WriteLine(total);

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}


