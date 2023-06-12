// See https://aka.ms/new-console-template for more information
//* 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
//* 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
//* declarado.

float[] numeros = new float[15];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"\nDigite o {i + 1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.Write($"{numeros[i]}, ");
}
