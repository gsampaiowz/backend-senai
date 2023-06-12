// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine($"Informe o número correspondente ao dia da semana - exemplo 2 p");

int diaSemana = int.Parse(Console.ReadLine()!);

switch (diaSemana)
{
    case 1:
    Console.WriteLine($"Hoje é domingo!");
    break;
    case 2:
    Console.WriteLine($"Hoje é segunda!");
    break;
    case 3:
    Console.WriteLine($"Hoje é terça!");
    break;
    case 4:
    Console.WriteLine($"Hoje é quarta!");
    break;
    case 5:
    Console.WriteLine($"Hoje é quinta!");
    break;
    case 6:
    Console.WriteLine($"Hoje é sexta!");
    break;
    case 7:
    Console.WriteLine($"Hoje é sábado!");
    break;
    default:
    Console.WriteLine($"O dia informado não corresponde com nenhum dia da semana.");
    break;
}

Console.ResetColor();