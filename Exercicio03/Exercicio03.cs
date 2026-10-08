Console.WriteLine("Nota do aluno: ");
float nota = float.Parse(Console.ReadLine());

if(nota >= 7)
{
    Console.Write("Aprovado...");
}
else if(nota  >= 5)
{
    Console.Write("Recuperação...");
}
else
{
    Console.Write("Reprovado...");
} 
