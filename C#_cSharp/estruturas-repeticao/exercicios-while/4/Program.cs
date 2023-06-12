// See https://aka.ms/new-console-template for more information
//* 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));

Console.WriteLine(@$"
DIGITE O SEU ESTADO CIVIL: 
's' para solteiro
'c' para casado
'v' para viúvo
'd' divorciado
");
char estadoCivil = char.Parse(Console.ReadLine()!);

switch (estadoCivil)
{
    case 's':
        Console.WriteLine($"SOLTEIRO!");
        break;
    case 'c':
        Console.WriteLine($"CASADO!");
        break;
    case 'v':
        Console.WriteLine($"VIÚVO!");
        break;
    case 'd':
        Console.WriteLine($"DIVORCIADO!");
        break;
    default:
        Console.WriteLine($"OPÇÃO INVÁLIDA!!!");
        break;
}

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"OPÇÃO INVÁLIDA!!!");
    Console.WriteLine(@$"
DIGITE NOVAMENTE: 
");
    estadoCivil = char.Parse(Console.ReadLine()!);

}




