// See https://aka.ms/new-console-template for more information
//* Faça um porgrama que receba 5 notas de um aluno e calcule a média aritmética. imprimir a resposta no console.

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine(@$"
---------------------------------------------------------------------------------------------------------------
                                   PROGRAMA PARA CALCULAR MÉDIA DE 5 NOTAS
---------------------------------------------------------------------------------------------------------------
                                                                                                             ");

Console.WriteLine($"Digite o valor da primeira nota: ");
float nota1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor da segunda nota: ");
float nota2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor da terceira nota: ");
float nota3 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor da quarta nota: ");
float nota4 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor da quinta nota: ");
float nota5 = float.Parse(Console.ReadLine()!);

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"A média das notas é: {media}");

Console.ResetColor();
