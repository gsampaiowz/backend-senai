// See https://aka.ms/new-console-template for more information
//* 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(@$"
-------------------------------
Digite um número inteiro de 1 a 10: ");
int num = int.Parse(Console.ReadLine()!);

while (num < 1 || num > 10)
{
    Console.WriteLine($"Por favor, digite um número entre 1 e 10!");
    num = int.Parse(Console.ReadLine()!);
}

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    int resultado = num * multiplicador;
    Console.WriteLine($"{num} x {multiplicador} = {resultado}");
}

Console.WriteLine($"Perfeito!");

Console.ResetColor();

