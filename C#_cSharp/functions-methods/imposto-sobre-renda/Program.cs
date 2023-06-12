// See https://aka.ms/new-console-template for more information
//* faça um método para calcular imposto sobre a renda

//* regras de negócio
//* tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

//*receber o renda via console
//*chamar o método passando a renda como parâmetro
//*exibir o valor do imposto referente á renda

Console.WriteLine($"\nDigite a sua renda, em reais: ");
float rendimento = float.Parse(Console.ReadLine()!);

static float CalcularImpostoRenda(float renda)
{
    while (renda < 0)
    {
        Console.WriteLine($"\nPor favor digite um valor positivo!");
        renda = float.Parse(Console.ReadLine()!);
    }
    if (renda > 0 && renda <= 1500)
    {
        Console.WriteLine($"\nIsento. Não paga imposto.");
    }
    else if (renda > 1500 && renda <= 3500)
    {
        return (float)20 / 100 * renda;
    }
    else if (renda > 3500 && renda <= 6000)
    {
        return (float)25 / 100 * renda;
    }
    else if (renda > 6000)
    {
        return (float)35 / 100 * renda;
    }
    return 0;
}

float impostoRenda = CalcularImpostoRenda(rendimento);

Console.WriteLine($"\nDeve pagar imposto de R$ {impostoRenda}, devido a sua renda de R$ {rendimento}.");