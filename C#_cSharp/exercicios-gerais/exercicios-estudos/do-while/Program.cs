// See https://aka.ms/new-console-template for more information
//* Escreva um algoritmo que pergunte a idade de um artista famoso e continue perguntando até ela acertar a idade correta.

//? INICIO

int tentativa = 0;
int idade = 0;

do
{
    tentativa++;
    Console.WriteLine($"\n Tenvativa {tentativa} \n Qual a idade do jogador Roger Guedes? ");
    idade = int.Parse(Console.ReadLine()!);
} while (idade != 26);

Console.WriteLine($"\n Acertou! \n");
