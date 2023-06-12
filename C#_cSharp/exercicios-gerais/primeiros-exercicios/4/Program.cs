// See https://aka.ms/new-console-template for more information

//* faça um programa para uma quitanda que receba o peso em kg de um alimento e calcule o valor da compra
//* pré-definir o valor do kg do produto

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(@$"
---------------------------------------------------------------------------------------------------------------
          PROGRAMA PARA CALCULAR PESO EM KG DO ALIMENTO E VALOR DA COMPRA
---------------------------------------------------------------------------------------------------------------
                                                                                                             ");

Console.WriteLine($"Quanto custa, em reais, o kg do alimento desejado?");
float kg = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual o peso, em kg, da sua compra?");
float peso = float.Parse(Console.ReadLine()!);

float valorCompra = kg * peso;

Console.WriteLine($"O valor da sua compra é: R${valorCompra}");

Console.ResetColor();
