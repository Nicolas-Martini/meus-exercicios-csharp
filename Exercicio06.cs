Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
 
Console.ReadKey(); 
