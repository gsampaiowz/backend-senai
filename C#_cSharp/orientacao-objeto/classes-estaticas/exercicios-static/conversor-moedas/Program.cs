using conversor_moedas;
using System.Globalization;

Console.WriteLine($"\nBem vindos ao meu conversor de moedas:");

string opcao;
do
{
    Console.WriteLine($"\nDigite o valor em reais que deseja converter: ");
    float valor = float.Parse(Console.ReadLine()!);

    Console.WriteLine(@$"
    MENU
    [1] - Para Dólar
    [2] - Para Euro
    [0] - Sair");
    opcao = Console.ReadLine()!;

    float valorConvertido;
    switch (opcao)
    {
        case "1":
            valorConvertido = ConversorMoedas.ConverterRealDolar(valor);
            Console.WriteLine($"\nO valor convertido é USD {valorConvertido.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

            break;
        case "2":
            valorConvertido = ConversorMoedas.ConverterRealEuro(valor);
            Console.WriteLine($"\nO valor convertido é {valorConvertido.ToString("C", CultureInfo.CreateSpecificCulture("EUR"))}");
            break;
        case "0":
            Console.WriteLine($"\nClique em qualquer tecla para encerrar");
            Console.ReadKey();
            Console.WriteLine($"\n Programa encerrado.");
            break;
    }
    Console.WriteLine($"\nClique em qualquer tecla para voltar ao MENU");
    Console.ReadKey();
} while (opcao != "0");