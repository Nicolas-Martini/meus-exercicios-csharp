float saldo = 3000;
float depositar = 0;
float sacar = 0;

Console.WriteLine("Qual opção deseja: ");
Console.WriteLine("1 - Ver saldo");
Console.WriteLine("2 - Depositar");
Console.WriteLine("3 - Sacar");
Console.WriteLine("4 - Sair");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine($"Saldo de R${saldo}");
        break;

    case 2:
        Console.WriteLine("Quanto quer depositar?");
        depositar = float.Parse(Console.ReadLine());
        saldo = saldo + depositar;
        Console.WriteLine($"Seu saldo agora é R${saldo}");
        break;

    case 3:
        Console.WriteLine("Quanto quer sacar?");
        sacar = float.Parse(Console.ReadLine());
        saldo = saldo - sacar;
        Console.WriteLine($"Seu saldo agora é R${saldo}");
        break;

    case 4:
        Console.WriteLine("Saindo...");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}
