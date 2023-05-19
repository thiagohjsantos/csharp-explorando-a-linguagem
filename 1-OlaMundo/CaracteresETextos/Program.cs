class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e textos\n");

        char letra = 'A';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "\nAlura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2023);

        string cursos = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();

    }
}


