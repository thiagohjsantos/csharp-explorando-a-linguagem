﻿class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        Console.WriteLine("Desáfio dedução IR\n");

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("A sua aliquota é de 7.5%");
            Console.WriteLine("Você pode deduzir até R$ 142");
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }
        else if (salario >= 3751.01 && salario <= 4664.0)
        {
            Console.WriteLine("A sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir até R$ 636");
        }
        else
            Console.WriteLine("Não há dedução disponível.");

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }

}



