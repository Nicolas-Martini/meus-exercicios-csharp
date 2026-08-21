/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
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