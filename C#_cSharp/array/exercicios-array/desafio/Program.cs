// See https://aka.ms/new-console-template for more information
//* Carregue um array de tamanho 6 com números inteiros. Calcule e imprima a qtnd de numeros impares e a qntd de numeros pares

int[] numeros = new int[6];

for (int i = 0; i < numeros.GetLength(0); i++)
{
    Console.WriteLine($"\nDigite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < numeros.GetLength(0); i++)
{
    if (numeros[i] % 2 == 1)
    {
        Console.WriteLine($"\nO número {numeros[i]} é Ímpar!");
    }
    else if (numeros[i] % 2 == 0)
    {
        Console.WriteLine($"\nO número {numeros[i]} é Par!");
    }
}
