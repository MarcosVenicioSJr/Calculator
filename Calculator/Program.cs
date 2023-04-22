using System;

Console.Clear();
Console.WriteLine("Digite o primeiro valor: ");
double valueOne = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
double valueTwo = Convert.ToDouble(Console.ReadLine());


static double Sum(double v1, double v2)
{
    return v1 + v2;
}