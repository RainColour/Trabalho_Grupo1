using AdivinharNumero; 
int opcao;

do
{
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Adivinhar número");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    if (opcao == 1)
    {
        Ad adivinhar = new Ad();
        adivinhar.Adivinhar();
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
