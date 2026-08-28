Console.WriteLine("Qual a sua altura (M): ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu peso (KG): ");
double peso = double.Parse(Console.ReadLine());

double resultado = IMC(peso, altura);

string classificacao = VerificarClassificacao(resultado);

Console.WriteLine($"Seu IMC é {resultado:F2}");
Console.WriteLine($"Classificação: {classificacao}");


static double IMC(double peso, double altura)
{
    return peso / (altura * altura);
}


static string VerificarClassificacao(double resultado)
{
    if (resultado <= 18.5)
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
