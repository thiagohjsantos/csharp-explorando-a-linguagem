class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo\n");

        int idade = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textAdicional;
        double salario = 3300.0;
        int mes = 5;

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

        /*Aliquota com IFs.

         
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
        } */


        /*Mês com switch 
     
        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês é Janeiro");
                break;
            case 2:
                Console.WriteLine("O mês é Fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês é Março");
                break;
            case 4:
                Console.WriteLine("O mês é Abril");
                break;
            case 5:
                Console.WriteLine("O mês é Maio");
                break;
            case 6:
                Console.WriteLine("O mês é Junho");
                break;
            case 7:
                Console.WriteLine("O mês é Julho");
                break;
            case 8:
                Console.WriteLine("O mês é Agosto");
                break;
            case 9:
                Console.WriteLine("O mês é Setembro");
                break;
            case 10:
                Console.WriteLine("O mês é Outubro");
                break;
            case 11:
                Console.WriteLine("O mês é Novembro");
                break;
            case 12:
                Console.WriteLine("O mês é Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        } */

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }

}


