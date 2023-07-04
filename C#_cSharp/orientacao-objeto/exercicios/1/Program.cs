/*Crie uma classe denominada Elevador para armazenar as informações de um elevador
dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
presentes nele. A classe deve também disponibilizar os seguintes métodos:
Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
andares no prédio (os elevadores sempre começam no térreo e vazio);
Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
espaço);
Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
dentro dele);
Subir : para subir um andar (não deve subir se já estiver no último andar);
Descer : para descer um andar (não deve descer se já estiver no térreo);
Encapsular todos os atributos da classe (criar os métodos set e get).*/

using _1;

Console.Clear();
bool reset = false;
do
{
    reset = false;

    Console.WriteLine($"\nSimulador de elevador");
    Console.WriteLine($"\nDigite a capacidade máxima do elevador:");
    int capacidade = int.Parse(Console.ReadLine());
    Console.WriteLine($"\nDigite o total de andares do elevador:");
    int totalAndares = int.Parse(Console.ReadLine());

    Elevador elevador = new Elevador(capacidade, totalAndares);

    string opcao;
    do
    {
        Console.WriteLine(@$"
Menu
1 - Entrar
2 - Sair
3 - Subir                Pessoas dentro: {elevador.PessoasDentro}
4 - Descer               Andar atual: {elevador.AndarAtual}
5 - Reinicializar
0 - Fechar programa
");
        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Clear();
                elevador.Entrar();
                break;
            case "2":
                Console.Clear();
                elevador.Sair();
                break;
            case "3":
                Console.Clear();
                elevador.Subir();
                break;
            case "4":
                Console.Clear();
                elevador.Descer();
                break;
            case "5":
                Console.Clear();
                reset = true;
                break;
            case "0":
                Console.Clear();
                Console.WriteLine($"\nFechando...");
                Thread.Sleep(1000);
                break;
            default:
                Console.Clear();
                Console.WriteLine($"\nOpção inválida.\nVoltando ao menu...");
                Thread.Sleep(1000);
                break;
        }
    } while (opcao != "0" && opcao != "5");
} while (reset == true);

