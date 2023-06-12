// See https://aka.ms/new-console-template for more information
//* Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

////! Inicializa a data e hora atuais
// DateTime dataAgora = DateTime.Now;
////! Inicializa a data atual
// DateTime dataHoje = DateTime.Today;

DateTime dataAgora = DateTime.Now;
DateTime dataHoje = DateTime.Today;
int diaAtual = dataAgora.Day;
int mesAtual = dataAgora.Month;

int anoAtual = 2013;

Console.WriteLine($"\n Digite o dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine()!);

while (dia < 1 || dia > 31)
{
    Console.WriteLine($"\n Vc precisa digitar um número de 1 a 31!");
    dia = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\n Digite o mês do seu aniversário: ");
int mes = int.Parse(Console.ReadLine()!);

while (mes < 1 || mes > 12)
{
    Console.WriteLine($"\n Vc precisa digitar um número de 1 a 12!");
    mes = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\n Digite o ano que vc nasceu: ");
int ano = int.Parse(Console.ReadLine()!);

while (ano > anoAtual)
{
    Console.WriteLine($"\n O ano que vc nasceu não pode ser maior do que o ano atual, digite novamente!");
    ano = int.Parse(Console.ReadLine()!);
}

while (mes > mesAtual)
{
    Console.WriteLine($"\n Identificamos que o mês da data digitada é futuro. Por favor digite um mês válido!");
    mes = int.Parse(Console.ReadLine()!);

    while (mes < 1 || mes > 12)
    {
        Console.WriteLine($"\n Vc precisa digitar um número de 1 a 12!");
        mes = int.Parse(Console.ReadLine()!);
    }

    while (dia > diaAtual)
    {
        Console.WriteLine($"\n Identificamos que o dia da data digitada é futuro. Por favor digite um dia válido!");
        dia = int.Parse(Console.ReadLine()!);

        while (dia < 1 || dia > 31)
        {
            Console.WriteLine($"\n Vc precisa digitar um número de 1 a 31!");
            dia = int.Parse(Console.ReadLine()!);
        }
    }
}

Console.WriteLine($"\n A sua data de aniversário é: {dia} / {mes} / {ano}");

