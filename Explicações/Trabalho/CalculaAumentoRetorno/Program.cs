using CalculaAumentoRetorno; //Importa o namespace CalculaAumentoRetorno, permitindo o acesso aos tipos definidos dentro dele.

int opcao; //Declaração de variáveis para armazenar a opção escolhida pelo usuário, o salário e a taxa de aumento.
double salario, taxa;

do // Inicia um loop do-while, que continuará executando o bloco de código dentro dele até que a opção escolhida pelo usuário seja 0 (sair).
{
    Console.WriteLine("0) Sair"); //Exibe no console a opção para sair.
    Console.WriteLine("1) Calcular Aumento"); //Exibe no console a opção para calcular o aumento.
    Console.Write("Escolha uma opção: "); //Lê a entrada do usuário do console e a converte para um número inteiro, atribuindo-a à variável opcao.
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1) //Se a opção escolhida for 1, o código dentro deste bloco será executado.
    {
        Console.Write("\nDigite o salário: R$ ");
        salario = double.Parse(Console.ReadLine()); //Lê a entrada do usuário para o salário e a converte para double.
        Console.Write("\nDigite a taxa de aumento (%): ");
        taxa = double.Parse(Console.ReadLine());

        CalculadoraAumento calculadora = new CalculadoraAumento(); // Cria uma instância da classe CalculadoraAumento.
        double nSalario = calculadora.CalcularAumento(salario, taxa); // Chama o método CalcularAumento da instância da calculadora para obter o novo salário.
        Console.WriteLine($"\nO novo salário é: R$ {nSalario}\n"); // Exibe o novo salário no console.
    }
    else if (opcao == 0) //Se a opção escolhida for 0, o código dentro deste bloco será executado, que mostra uma mensagem de saída.
    {
        Console.WriteLine("Saindo...");
        Console.WriteLine("\r\nVinicius Mota - 2022102148\r\nLuiz Vinicius - 2022102059\r\nPedro Yago - 2022102058");
    }
    else // Se a opção escolhida não for nem 0 nem 1, o código dentro deste bloco será executado, exibindo uma mensagem de opção inválida.
    {
        Console.WriteLine("Opção inválida. Escolha outra opção.");
    }

} while (opcao != 0);