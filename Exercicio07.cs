using System.Globalization;

Console.WriteLine("--- Calculadora de IMC ---");

Console.Write("Qual a sua altura (ex: 1.75): ");
if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double altura) || altura <= 0)
{
    Console.WriteLine("Altura inválida. Execute o programa novamente.");
    return;
} 

Console.Write("Qual o seu peso em kg (ex: 70.5): ");
if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double peso) || peso <= 0)
{
    Console.WriteLine("Peso inválido. Execute o programa novamente.");
    return;
}

double resultado = CalcularIMC(peso, altura);
string classificacao = VerificarClassificacao(resultado);

Console.WriteLine($"\nSeu IMC é: {resultado:F2}");
Console.WriteLine($"Classificação: {classificacao}");

static double CalcularIMC(double peso, double altura)
{
    return peso / (altura * altura);
}

static string VerificarClassificacao(double resultado)
{
    if (resultado < 18.5)
    {
        return "Abaixo do peso";
    }
    else if (resultado <= 24.9)
    {
        return "Peso normal";
    }
    else if (resultado <= 29.9)
    {
        return "Sobrepeso";
    }
    else if (resultado <= 34.9)
    {
        return "Obesidade grau I";
    }
    else if (resultado <= 39.9)
    {
        return "Obesidade grau II";
    }
    else
    {
        return "Obesidade grau III";
    }
}
