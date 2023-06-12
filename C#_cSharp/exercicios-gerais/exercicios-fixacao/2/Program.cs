// See https://aka.ms/new-console-template for more information

//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

//? recebe e armazena quantos gols o time 1 fez, recebe e armazena quantos gols o time 2 fez, e mostra se foi empate, ou de quem foi a vitória.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
            PROGRAMA PARA CALCULAR DE QUAL TIME FOI A VITÓRIA, DE ACORDO COM UM PLACAR RECEBIDO
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Quantos gols o Corinthians fez?");
int timao = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols o Palmeiras fez?");
int verdao = int.Parse(Console.ReadLine()!);

if (timao > verdao)
{
    Console.WriteLine($"VAI CORINTHIANS!!!");

}
else if (verdao > timao)
{
    Console.WriteLine($"VAI PALMEIRAS!!!");

}
else
{
    Console.WriteLine($"EMPATE.");

}

Console.ResetColor();