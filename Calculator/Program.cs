using System;

Console.Clear();

Console.WriteLine("Digite qual operação você deseja: ");
string operationMath = Console.ReadLine().ToLower();

Console.WriteLine("Digite o primeiro valor: ");
double valueOne = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
double valueTwo = Convert.ToDouble(Console.ReadLine());


switch (operationMath)
{
    case "soma":
        Console.WriteLine("O valor é: " + Sum(valueOne, valueTwo));
        break;
    case "subtração":
        Console.WriteLine("O valor é: " + Subtraction(valueOne, valueTwo));
        break;
    case "divisão":
        Console.WriteLine("O valor é: " + Division(valueOne, valueTwo));
        break;
    case "multiplicação":
        Console.WriteLine("O valor é: " + Multiply(valueOne, valueTwo));
        break;
    default:
        Console.WriteLine("Operação não encontrada.");
        break;
}

static double Sum(double v1, double v2)
{
    return v1 + v2;
}

static double Subtraction(double v1, double v2)
{
    return (v1 - v2);
}

static double Multiply(double v1, double v2)
{
    return v1 * v2;
}

static double Division(double v1, double v2)
{
    return v1 / v2;
}