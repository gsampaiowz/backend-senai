// See https://aka.ms/new-console-template for more information
//* 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(@$"
-------------------------------
Digite a sua nota, de 0 a 10: ");
float nota = float.Parse(Console.ReadLine()!);

while (nota < 0 || nota > 10)
{
    Console.WriteLine($"Por favor, digite uma nota entre 0 e 10!");
    nota = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Perfeito!");

Console.ResetColor();
