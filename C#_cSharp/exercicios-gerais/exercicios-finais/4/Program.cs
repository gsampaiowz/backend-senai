// See https://aka.ms/new-console-template for more information
//* 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

float[] numeros = new float[3];

for (var i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"\nDigite o {i + 1}º valor: ");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\nO menor valor digitado foi: {numeros.Min()}\nO maior valor digitado foi: {numeros.Max()}");
