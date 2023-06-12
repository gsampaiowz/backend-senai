// See https://aka.ms/new-console-template for more information
/*
6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

Exemplo: tabuada do 1, tabuada do 2, etc...
Dica: utilize um laço dentro do outro.

!ALGORITMO
para num = 1; num <= 10; num++
    escreva tabuada do {num}
    para multiplicador = 1; multiplicador <= 10; multiplicador++
        resultado = num * multiplicador;
        escreva num x multiplicador = resultado
*/

for (int num = 1; num <= 10; num++)
{
    Console.WriteLine($"\nTABUADA DO NÚMERO: {num}");

    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int resultado = num * multiplicador;
        Console.WriteLine($"{num} x {multiplicador} = {resultado}");
    }

}