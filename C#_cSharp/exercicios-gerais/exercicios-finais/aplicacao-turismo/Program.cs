// See https://aka.ms/new-console-template for more information

string[] nomePassageiros = new string[2];
string[] origens = new string[5];
string[] destinos = new string[5];
string[] datas = new string[5];

Console.WriteLine($"\nAgência de Turismo");

Console.WriteLine($"\nDigite o nome de usuário: ");
string nomeUsuario = Console.ReadLine()!;

while (nomeUsuario != "dev")
{
    Console.WriteLine($"Nome de usuário incorreto!");
    nomeUsuario = Console.ReadLine()!;
}

Console.WriteLine($"\nDigite a senha de acesso: ");
string senha = Console.ReadLine()!;

while (senha != "senai134")
{
    Console.WriteLine($"\nSenha incorreta!");
    senha = Console.ReadLine()!;
}
Console.WriteLine($"\nCarregando...");
Thread.Sleep(1000);

Console.WriteLine($"\nAcesso bem sucedido!");

bool voltarMenu;
int escolha = 0;

do
{
    voltarMenu = false;
    Console.WriteLine(@$"
_________________________
|          Menu         |
|-----------------------|
| 1. Cadastrar passagens| 
| 2. Listar passagens   |
| 0. Sair               | 
-------------------------");
    Console.WriteLine($"\nO que deseja fazer?");
    escolha = int.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1:
            char cadastroNovamente;
            do
            {
                for (var i = 0; i < nomePassageiros.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nDigite o nome do {i + 1}º passageiro: ");
                    nomePassageiros[i] = Console.ReadLine()!;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nDigite a origem do {i + 1}º passageiro: ");
                    origens[i] = Console.ReadLine()!;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\nDigite o destino do {i + 1}º passageiro: ");
                    destinos[i] = Console.ReadLine()!;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nDigite a data da viagem do {i + 1}º passageiro: Exemplo: 26/05/2023");
                    datas[i] = Console.ReadLine()!;
                    Console.ResetColor();
                }
                Console.WriteLine($"\nGostaria de cadastrar novas passagens? S/N");
                cadastroNovamente = char.Parse(Console.ReadLine()!.ToUpper());
            } while (cadastroNovamente == 'S');
            voltarMenu = true;
            break;
        case 2:

            for (var i = 0; i < nomePassageiros.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nNome do {i + 1}º passageiro: {nomePassageiros[i]}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nOrigem do {i + 1}º passageiro: {origens[i]}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\nDestino do {i + 1}º passageiro: {destinos[i]}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nData da viagem do {i + 1}º passageiro: {datas[i]}");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
            voltarMenu = true;
            break;
        case 0:
            Console.WriteLine($"\nEncerrando...");
            Thread.Sleep(1000);
            Console.WriteLine($"Programa encerrado.");
            break;
        default:
            Console.WriteLine($"Opção Inválida!");
            voltarMenu = true;
            break;
    }
} while (voltarMenu == true);

