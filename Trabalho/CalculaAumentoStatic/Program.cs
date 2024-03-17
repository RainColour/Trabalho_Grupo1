using CalculaAumentoStatic;

int opcao;
double salario, taxa;

do
{
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Calcular Aumento");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("\nDigite o salário: R$ ");
        salario = double.Parse(Console.ReadLine());
        Console.Write("\nDigite a taxa de aumento (%): ");
        taxa = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nO novo salário é: R$ {CalculadoraAumentoS.CalcularAumento(salario, taxa)}\n");
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Saindo...");
        Console.WriteLine("\r\nVinicius Mota - 2022102148\r\nLuiz Vinicius - 2022102059\r\nPedro Yago - 2022102058");
    }
    else
    {
        Console.WriteLine("Opção inválida. Escolha outra opção.");
    }
} while (opcao != 0);