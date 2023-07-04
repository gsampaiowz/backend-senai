/*3.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.*/

using _3;

Console.Clear();

Console.WriteLine($"Bem-vindo a calculadora de aposentadoria");

string opcao;
do
{
    Console.WriteLine(@$"
    Escolha a posição do jogador
    1 - Defesa 
    2 - Meio Campo
    3 - Ataque");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            JogadorDefesa defensor = new JogadorDefesa();
            defensor.MostrarDados();
            defensor.CalcularIdade();
            defensor.CalcularAposentadoria();
            break;
        case "2":
            Console.Clear();
            JogadorMeioCampo meioCampo = new JogadorMeioCampo();
            meioCampo.MostrarDados();
            meioCampo.CalcularIdade();
            meioCampo.CalcularAposentadoria();
            break;
        case "3":
            Console.Clear();
            JogadorAtaque atacante = new JogadorAtaque();
            atacante.MostrarDados();
            atacante.CalcularIdade();
            atacante.CalcularAposentadoria();
            break;
        default:
            Console.Clear();
            Console.WriteLine($"\nOpção inválida");
            break;
    }

} while (opcao != "0");