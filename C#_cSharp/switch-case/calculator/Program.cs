// See https://aka.ms/new-console-template for more information

//? vamos criar uma calculadora usando switch case

//? lógica - algoritmo

//1. definir operação
//2. informar primeiro número
//3. informar segundo número
//4. processar os dados inseridos
//5. exibir o resultado

Console.ForegroundColor = ConsoleColor.DarkMagenta;

//! entrada

Console.WriteLine(@$"
-----------------------------------------
    Programa Calculadora
    --------------------
    Informe a operação matemática que deseja efetuar:
    '+' para somar
    '-' para subtrair
    '*' para multiplicar
    '/' para dividir
");

//* recebe a operação escolhida
Console.WriteLine($"Digite a operação desejada: ");
char operacao = char.Parse(Console.ReadLine()!);

//* entrada do primeiro número
Console.WriteLine($"Digite o valor do primeiro número: ");

float n1 = float.Parse(Console.ReadLine()!);

//* entrada do segundo número
Console.WriteLine($"Digite o valor do segundo número: ");

float n2 = float.Parse(Console.ReadLine()!);

//* declarado a variável que receberá o resultado

float result = 0;

//! processamento

switch (operacao)
{
    case '+':
        result = (n1+n2);
        Console.WriteLine($"O resultado da soma é {result}");
        break;
    case '-':
        result = n1-n2;
        Console.WriteLine($"O resultado da subtração é {result}");
        break;
    case '*':
        result = n1*n2;
        Console.WriteLine($"O resultado da multiplicação é {result}");
        break;
    case '/':
        result = n1/n2;
        Console.WriteLine($"O resultado da divisão é {result}");
        break;
    default:
        Console.WriteLine($"A operação informada não é suportada por essa calculadora!");
        break;        
}

Console.ResetColor();