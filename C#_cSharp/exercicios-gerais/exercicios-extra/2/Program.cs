// See https://aka.ms/new-console-template for more information
//* Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"\n Digite um número: ");
float numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"\n Digite outro número: ");
float numero2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"\n Digite mais um número: ");
float numero3 = float.Parse(Console.ReadLine()!);

if (numero1 > numero2 && numero2 > numero3)
{
    Console.WriteLine($"\n {numero1} é o MAIOR \n {numero3} é o MENOR");
}
else if (numero1 > numero3 && numero3 > numero2)
{
    Console.WriteLine($"\n {numero1} é o MAIOR \n {numero2} é o MENOR");
}
else if (numero2 > numero1 && numero1 > numero3)
{
    Console.WriteLine($"\n {numero2} é o MAIOR \n {numero3} é o MENOR");
}
else if (numero2 > numero3 && numero3 > numero1)
{
    Console.WriteLine($"\n {numero2} é o MAIOR \n {numero1} é o MENOR");
}
else if (numero3 > numero2 && numero2 > numero1)
{
    Console.WriteLine($"\n {numero3} é o MAIOR \n {numero1} é o MENOR");
}
else if (numero3 > numero1 && numero1 > numero2)
{
    Console.WriteLine($"\n {numero3} é o MAIOR \n {numero2} é o MENOR");
}
else
{
    Console.WriteLine($"\n Números iguais identificados!");

}