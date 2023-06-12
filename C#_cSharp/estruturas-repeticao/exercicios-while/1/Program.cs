// See https://aka.ms/new-console-template for more information
//* 1. Nome: diferente de vazio;

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine()!;

while (nome == string.Empty)
{
    Console.WriteLine($"Por favor, não deixe esse campo vazio.");
    Console.WriteLine($"Digite seu nome: ");
    nome = Console.ReadLine()!;
}

Console.WriteLine($"BELO NOME!");
