// See https://aka.ms/new-console-template for more information
//* Escreva um algoritmo que pergunte a idade de um artista famoso e continue perguntando até ela acertar a idade correta.

//? INICIO

Console.WriteLine($"\n Qual a idade do jogador Roger Guedes? ");
int idade = int.Parse(Console.ReadLine()!);

int tentativa = 1;

while (idade != 26)
{
    tentativa++;
    Console.WriteLine($"\n Errou meu parceiro. \n Tenvativa {tentativa} \n Qual a idade do jogador Roger Guedes? ");
    idade = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\n Acertou! \n");
