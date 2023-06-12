// See https://aka.ms/new-console-template for more information
//* Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine($"\n Digite uma letra: ");
char letra = char.Parse(Console.ReadLine()!.ToUpper());

switch (letra)
{
    case 'A':
        Console.WriteLine($"\n Letra digitada é uma vogal!");
        break;
    case 'E':
        Console.WriteLine($"\n Letra digitada é uma vogal!");
        break;
    case 'I':
        Console.WriteLine($"\n Letra digitada é uma vogal!");
        break;
    case 'O':
        Console.WriteLine($"\n Letra digitada é uma vogal!");
        break;
    case 'U':
        Console.WriteLine($"\n Letra digitada é uma vogal!");
        break;
    default:
        Console.WriteLine($"\n Letra digitada é uma consoante! \n");
        break;
}
