Console.WriteLine($"\nSistema de acesso aos exercícios: ");

string escolha;
do
{
    Console.ResetColor();
    Console.WriteLine(@$"
Exercícios: 
[1] - Agência de turismo
[2] - Posto de gasolina
[3] - Sistema de produtos
            OU
[0] - Encerrar o programa
");
    escolha = Console.ReadLine()!;

    switch (escolha)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Blue;
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

            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Magenta;
            float valorDescontado = 0;
            float valor = 0;

            const float precoAlcool = 4.90F;
            const float precoGasolina = 5.30F;

            static float CalculoDesconto(float litros, char combustivel)
            {
                float desconto = 0;
                if (combustivel == 'A')
                {
                    if (litros > 0 && litros <= 20)
                    {
                        return (float)3 / 100;
                    }
                    else if (litros > 20)
                    {
                        return (float)5 / 100;
                    }
                }
                else if (combustivel == 'G')
                {
                    if (litros > 0 && litros <= 20)
                    {
                        return (float)3 / 100;
                    }
                    else if (litros > 20)
                    {
                        return (float)5 / 100;
                    }
                }
                return desconto;
            }

            Console.WriteLine($"\nPOSTO SAMPAIO");

            Console.WriteLine($"\nEscolha o tipo de combustível: \nDigite 'A' para ÁLCOOL ou 'G' para GASOLINA.");
            char combustivel = char.Parse(Console.ReadLine()!.ToUpper());

            while (combustivel != 'A' && combustivel != 'G')
            {
                Console.WriteLine($"\nOpção inválida! Digite 'A' para ÁLCOOL ou 'G' para GASOLINA!");
                combustivel = char.Parse(Console.ReadLine()!.ToUpper());
            }

            Console.WriteLine($"\nAgora, digite a quantidade de litros desejada:");
            float litros = float.Parse(Console.ReadLine()!);

            while (litros < 0)
            {
                Console.WriteLine($"\nValor inválido! Digite um valor positivo!");
                litros = float.Parse(Console.ReadLine()!);
            }

            float desconto = CalculoDesconto(litros, combustivel);

            switch (combustivel)
            {
                case 'A':
                    valor = precoAlcool * litros;
                    break;
                case 'G':
                    valor = precoGasolina * litros;
                    break;
            }

            valorDescontado = valor - (valor * desconto);
            float descontoPorcentagem = desconto * 100;

            Console.WriteLine($"\nValor sem desconto: R$ {valor}\nValor com desconto de {descontoPorcentagem}%: R$ {valorDescontado}");

            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Cozinhando...");
            Thread.Sleep(1500);
            break;
        case "0":
            Console.WriteLine($"Encerrando...");
            Thread.Sleep(3000);
            Console.WriteLine($"Programa encerrado.");
            break;
        default:
            Console.WriteLine($"\nOpção inválida!");
            break;
    }
} while (escolha != "0");

