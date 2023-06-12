// See https://aka.ms/new-console-template for more information
//? mini calculadora
Console.WriteLine($"\nDigite o valor do primeiro número: ");
float n1 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"\nDigite o valor do segundo número: ");
float n2 = float.Parse(Console.ReadLine()!);

//* criar método para somar 2 números

static float Soma(float n1, float n2)
{

    return (n1 + n2);
}

float soma = Soma(n1, n2);

//* criar método para subtrair 2 números

static float Sub(float n1, float n2)
{

    return (n1 - n2);
}

float sub = Sub(n1, n2);

//* criar método para multiplicar 2 números

static float Multi(float n1, float n2)
{

    return (n1 * n2);
}

float multi = Multi(n1, n2);

//* criar método para dividir 2 números

static float Div(float n1, float n2)
{

    return (n1 / n2);
}

float div = Div(n1, n2);

bool loopContinue = true;
while (loopContinue)
{
    Console.WriteLine($"\n MINI CALCULADORA \nDigite: \n1 para SOMA; \n2 para SUBTRAÇÃO \n3 para MULTIPLICAÇÃO \n4 para DIVISÃO");
    int operacao = int.Parse(Console.ReadLine()!);
    switch (operacao)
    {
        case 1:
            Console.WriteLine($"\nResultado da soma: {soma}");
            loopContinue = false;
            break;

        case 2:
            Console.WriteLine($"\nResultado da subtração: {sub}");
            loopContinue = false;
            break;

        case 3:
            Console.WriteLine($"\nResultado da multiplicação: {multi}");
            loopContinue = false;
            break;

        case 4:
            Console.WriteLine($"\nResultado da divisão: {div}");
            loopContinue = false;
            break;
        default:
            Console.WriteLine($"\nOpção Inválida! Digite novamente!");
            break;
    }

}


