float saldo = 3000;
float depositar = 0;
float sacar = 0;
int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("\nQual opção deseja:");  
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Saldo de R${saldo}");
            break;

        case 2:
            Console.WriteLine("Quanto quer depositar?");
            depositar = float.Parse(Console.ReadLine());

            if (depositar <= 0)
            {
                Console.WriteLine("ERRO... O valor do depósito deve ser maior que zero.");
            }
            else
            {
                saldo = saldo + depositar;
                Console.WriteLine($"Depósito realizado!");
                Console.WriteLine($"Seu saldo agora é R${saldo}");
            }

            break;

        case 3:
            Console.WriteLine("Quanto quer sacar?");
            sacar = float.Parse(Console.ReadLine());

            if (sacar <= 0)
            {
                Console.WriteLine("ERRO... O valor do saque deve ser maior que zero.");
            }
            else if (sacar > saldo)
            {
                Console.WriteLine("ERRO... Saldo insuficiente.");
            }
            else
            {
                saldo = saldo - sacar;
                Console.WriteLine($"Saque realizado!");
                Console.WriteLine($"Seu saldo agora é R${saldo}");
            }

            break;

        case 4:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
