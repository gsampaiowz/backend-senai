//criação de variáveis
int tamanhoArrays = 2;

string[] nomes = new string[tamanhoArrays];
float[] precos = new float[tamanhoArrays];
bool[] promocoes = new bool[tamanhoArrays];

int proxPosicao = 1;
static void CadastrarProduto(string[] nomes, float[] precos, bool[] promocoes, int pos)
{
    Console.WriteLine($"\nDigite o nome do produto: ");
    nomes[pos] = Console.ReadLine()!;
    Console.WriteLine($"\nDigite o preço do produto: ");
    precos[pos] = float.Parse(Console.ReadLine()!);
    string promocao;
    do
    {
        Console.WriteLine($"\nO produto está em promoção? s/n ");
        promocao = Console.ReadLine()!.ToLower();
        if (promocao == "s")
        {
            promocoes[pos] = true;
        }
        else
        {
            promocoes[pos] = false;
        }
    } while (promocao != "s" && promocao != "n");
}

static void ListarProdutos(string[] nomes, float[] precos, bool[] promocoes, int pos)
{

    if (promocoes[pos])
    {
        Console.WriteLine(@$"
            Produto: {nomes[pos]}
            Preço: {precos[pos]}
            Está em promoção? Sim");
    }
    else
    {
        Console.WriteLine(@$"
            Produto: {nomes[pos]}
            Preço: {precos[pos]}
            Está em promoção? Não");
    }

}
string opcao;
do
{
    Console.ResetColor();
    Console.WriteLine(@$"
Menu de opções
[1] - Cadastrar produto (máximo de {tamanhoArrays} produtos)
[2] - Listar produtos cadastrados
[0] - Encerrar programa
");
    opcao = Console.ReadLine()!;
    Console.WriteLine($"--------------------------------------------------------------------------");
    switch (opcao)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            string maisCadastro = "s";
            int i;
            do
            {
                for (i = 0; i < proxPosicao; i++)
                {
                    if (i < tamanhoArrays && maisCadastro == "s")
                    {
                        CadastrarProduto(nomes, precos, promocoes, i);
                        proxPosicao++;
                        Console.WriteLine($"\nQuer cadastrar mais um produto? ");
                        maisCadastro = Console.ReadLine()!;
                    }
                }
                if (maisCadastro == "s")
                {
                    Console.WriteLine($"\nImpossível cadastrar mais produtos. Limite atingido!");
                    maisCadastro = "n";
                }
            } while (maisCadastro == "s");
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (proxPosicao == 1)
            {
                Console.WriteLine($"\nNão há produtos cadastrados!");
            }
            else
            {
                for (i = 0; i < proxPosicao - 1; i++)
                {
                    ListarProdutos(nomes, precos, promocoes, i);
                    Thread.Sleep(1500);
                }
            }
            break;
        case "0":
            Console.WriteLine($"\nEncerrando...");
            Thread.Sleep(2000);
            Console.WriteLine($"\nPrograma encerrado.");
            break;
        default:
            Console.WriteLine($"\nOpção inválida!");
            break;
    }
} while (opcao != "0");
