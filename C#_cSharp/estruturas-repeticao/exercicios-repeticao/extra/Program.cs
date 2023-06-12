// See https://aka.ms/new-console-template for more information
/*
***********DESAFIO************

 Pesquise como funciona o algoritmo Fibonacci.
 Faça um programa que gere a série até que o valor seja maior que 500. 

*Algoritmo
numeroAnterior = 0;
for numero = 1; numero <= 500; numero += anterior;
    escreva numero;
    numeroAnterior = numero;
*/

//? INICIO

int numeroAntesAnterior = 0;
int numeroAnterior = 1;

Console.WriteLine($"Digite o valor máximo para essa sequência de Fibonacci: ");
int numeroMaximo = int.Parse(Console.ReadLine()!);

int numero = 0;
do
{
    numeroAntesAnterior = numeroAnterior;
    numeroAnterior = numero;
    numero = numeroAntesAnterior + numeroAnterior;
    Console.Write($"{numero} => ");
} while (numero < numeroMaximo);

