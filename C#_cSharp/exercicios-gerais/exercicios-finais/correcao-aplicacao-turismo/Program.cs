

//* criando as funções

//* estrutura de uma função

//tipo tipoDado nomeFuncao(parâmetros ou argumentos)
{
    //corpo da função
}

static bool Login(string senha)
{
    if (senha == "123456")
    {
        Console.WriteLine($"Carregando...");
        Thread.Sleep(3000);
        Console.WriteLine($"\nAcesso bem sucedido!");

        return true;
    }
    else
    {
        Console.WriteLine($"\nSenha incorreta.");

        return false;
    }
}

//* declarar as variáveis
string[] nomes = new string[5];
string[] origens = new string[5];
string[] destinos = new string[5];
string[] datas = new string[5];

bool senhaValida;
do
{
    Console.WriteLine($"\nInforme a sua senha: ");
    string senha = Console.ReadLine()!;
    senhaValida = Login(senha);

} while (senhaValida == false);

static void CadastrarPassagens(string[] nomes, string[] origens, string[] destinos, string[] datas, int i)
{
    Console.WriteLine($"\nInforme o nome do {i + 1}º: ");
    nomes[i] = Console.ReadLine()!;
    Console.WriteLine($"\nInforme a origem do {i + 1}º: ");
    origens[i] = Console.ReadLine()!;
    Console.WriteLine($"\nInforme o destino do {i + 1}º: ");
    destinos[i] = Console.ReadLine()!;
    Console.WriteLine($"\nInforme a data do {i + 1}º: ");
    datas[i] = Console.ReadLine()!;
}
static void ListarPassagens(string[] nomes, string[] origens, string[] destinos, string[] datas, int i)
{
    Console.WriteLine(@$"
            *******************
            Passagens - Bilhete {i + 1}
            Nome: {nomes[i]}
            Origem: {origens[i]}
            Destino: {destinos[i]}
            Data: {datas[i]}");
    Thread.Sleep(3000);

}

//* criar menu de opções
string opcao;
do
{
    Console.WriteLine($"\nMenu de opções");
    Console.WriteLine(@$"
Selecione uma das opções
[1] - Cadastrar
[2] - Listar
[0] - Sair
");
    opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            string maisPassagem;
            do
            {
                for (var i = 0; i < nomes.Length; i++)
                {
                    CadastrarPassagens(nomes, origens, destinos, datas, i);
                }
                Console.WriteLine($"\nDeseja cadastrar mais passagens? s/n");
                maisPassagem = Console.ReadLine()!.ToLower();

            } while (maisPassagem == "s");
            break;
        case "2":
            for (var i = 0; i < nomes.Length; i++)
            {
                ListarPassagens(nomes, origens, destinos, datas, i);
            }
            break;
        case "0":
            Console.WriteLine($"Encerrando...");
            Thread.Sleep(3000);
            Console.WriteLine($"\nPrograma encerrado.");
            break;

        default:
            Console.WriteLine($"\nOpção inválida!");
            break;
    }
} while (opcao != "0");
