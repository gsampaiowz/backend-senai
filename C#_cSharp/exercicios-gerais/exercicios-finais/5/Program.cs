// See https://aka.ms/new-console-template for more information
//* Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
//* Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\nTabuada do {i}");
    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int resultado = i * multiplicador;
        Console.WriteLine($"{i} X {multiplicador} = {resultado}");
    }
}