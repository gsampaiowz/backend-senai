// See https://aka.ms/new-console-template for more information
//* Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"\n Digite o raio uma circunferência, em cm: ");
float raio = float.Parse(Console.ReadLine()!);

float diametro = raio * 2;
float comprimento = (float)(2 * Math.PI * raio);
float area = (float)(Math.PI * (Math.Pow(raio, 2)));

Console.WriteLine($"\n O diâmetro é: {diametro} cm");
Console.WriteLine($"\n O comprimento é: {comprimento} cm");
Console.WriteLine($"\n A área é: {area} cm \n");