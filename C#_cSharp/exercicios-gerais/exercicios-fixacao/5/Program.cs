// See https://aka.ms/new-console-template for more information

// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
            PROGRAMA PARA CALCULAR QUAL SERÁ O PREÇO DE UMA CERTA QUANTIDADE DE MAÇÃS
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Quantas maçãs você vai comprar? ");
int macas = int.Parse(Console.ReadLine()!);

float precoMacas = 0.30F;

if (macas >= 12)
{
    precoMacas = 0.25F;
}

float precoTotal = macas * precoMacas;
Console.WriteLine($"O preço final é: {Math.Round(precoTotal, 2)}");


Console.ResetColor();
