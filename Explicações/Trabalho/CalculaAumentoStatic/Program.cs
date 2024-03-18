using CalculaAumentoStatic; //Importa o namespace CalculaAumentoStatic, permitindo o acesso aos tipos definidos dentro dele.

int opcao; //Declaração de variáveis para armazenar a opção escolhida pelo usuário, o salário e a taxa de aumento.
double salario, taxa;

do //Inicia um loop do-while, que continuará executando o bloco de código dentro dele até que a opção escolhida pelo usuário seja 0 (sair).
{
    Console.WriteLine("0) Sair"); // Exibe no console a opção para sair.
    Console.WriteLine("1) Calcular Aumento"); // Exibe no console a opção para calcular o aumento.
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()); //  Lê a entrada do usuário do console e a converte para um número inteiro, atribuindo-a à variável opcao.

    if (opcao == 1) // Se a opção escolhida for 1, o código dentro deste bloco será executado.
    {
        Console.Write("\nDigite o salário: R$ ");
        salario = double.Parse(Console.ReadLine()); //Lê a entrada do usuário para o salário e a converte para double.
        Console.Write("\nDigite a taxa de aumento (%): ");
        taxa = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nO novo salário é: R$ {CalculadoraAumentoS.CalcularAumento(salario, taxa)}\n"); // Chama o método CalcularAumento diretamente da classe CalculadoraAumentoS usando a sintaxe de chamada estática, calcula o novo salário e exibe no console.
    }
    else if (opcao == 0) // Se a opção escolhida for 0, o código dentro deste bloco será executado, que mostra uma mensagem de saída.
    {
        Console.WriteLine("Saindo...");
        Console.WriteLine("\r\nVinicius Mota - 2022102148\r\nLuiz Vinicius - 2022102059\r\nPedro Yago - 2022102058");
    }
    else // Se a opção escolhida não for nem 0 nem 1, o código dentro deste bloco será executado, exibindo uma mensagem de opção inválida.
    {
        Console.WriteLine("Opção inválida. Escolha outra opção.");
    }
} while (opcao != 0);

//diferença:
//No primeiro código (CalculaAumentoRetorno), a funcionalidade de cálculo de aumento é encapsulada em uma classe normal (CalculadoraAumento). 
//Para utilizar essa funcionalidade, você precisa criar uma instância dessa classe e então chamar o método CalcularAumento dessa instância.

//No segundo código (CalculaAumentoStatic), a funcionalidade é encapsulada em uma classe estática (CalculadoraAumentoS).
//Classes estáticas são convenientes quando você não precisa armazenar dados de estado, e as funcionalidades fornecidas pela classe são independentes de qualquer instância específica.
//Portanto, você não precisa criar uma instância da classe estática; pode chamar diretamente o método CalcularAumento usando o nome da classe.

//No primeiro código, para calcular o aumento, você instancia a classe CalculadoraAumento e, em seguida, chama o método CalcularAumento dessa instância, como em:
//CalculadoraAumento calculadora = new CalculadoraAumento();
//double nSalario = calculadora.CalcularAumento(salario, taxa)

//No segundo código, como a classe CalculadoraAumentoS é estática, você chama o método CalcularAumento diretamente usando o nome da classe, 
//sem a necessidade de criar uma instância, como em:

//nSalario = CalculadoraAumentoS.CalcularAumento(salario, taxa);