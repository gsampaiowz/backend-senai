// See https://aka.ms/new-console-template for more information
//? Escreva um algoritmo que exiba todos os números inteiros de 0 a 50

Console.WriteLine($"\n CONTAGEM DE 0 A 50 \n");

for (int numero = 0; numero <= 50; numero++)
{
    Console.Write($"{numero} ");
    Thread.Sleep(50);
}

Console.WriteLine($"\n\n CONTAGEM DE 200 A 100 \n");

for (int numero = 200; numero >= 100; numero--)
{
    Console.Write($"{numero} ");
    Thread.Sleep(50);
}
