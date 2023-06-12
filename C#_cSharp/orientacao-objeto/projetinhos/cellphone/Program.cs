using cellphone;

Celular smartphone = new Celular();

Console.WriteLine($"\nQual a cor do celular?");
smartphone.cor = Console.ReadLine()!;

Console.WriteLine($"\nQual o modelo do celular?");
smartphone.modelo = Console.ReadLine()!;

Console.WriteLine($"\nQual o tamanho do celular?");
smartphone.tamanho = Console.ReadLine()!;

Console.WriteLine($"\n-------Celular");

string ligar;
do
{
    do
    {
        Console.WriteLine($"\nDigite L para ligar o celular!");
        ligar = Console.ReadLine()!.ToLower();
        smartphone.ligado = ligar == "l";
    } while (smartphone.ligado != true);
    smartphone.Ligar();
    string opcao;
    do
    {
        Console.WriteLine(@$"
Menu do Celular
[1] - Fazer ligação
[2] - Enviar mensagem
[0] - Desligar");
        opcao = Console.ReadLine()!;
        switch (opcao)
        {
            case "1":
                smartphone.FazerLigacao();
                break;
            case "2":
                smartphone.EnviarMensagem();
                break;
            case "0":
                smartphone.Desligar();
                break;
            default:
                Console.WriteLine($"\nOpção inválida!");
                break;
        }

    } while (opcao != "0");

} while (smartphone.ligado == false);

