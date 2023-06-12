// See https://aka.ms/new-console-template for more information
//* Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
//* Imprima o resultado no console.

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
                    PROGRAMA PARA CALCULAR IDADE EM MESES, DIAS, HORAS E MINUTOS
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Quantos anos você têm?");
int anos = int.Parse(Console.ReadLine()!);

float meses = anos * 12;
float dias = anos * 365;
float horas = dias * 24;
float minutos = horas * 60;

Console.WriteLine(@$"A sua idade em meses é {meses}, em dias é {dias}, em horas é {horas} e em minutos é {minutos}.
                                                                                                                  ");

Console.ResetColor();