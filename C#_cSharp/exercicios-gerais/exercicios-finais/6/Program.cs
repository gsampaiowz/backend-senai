// See https://aka.ms/new-console-template for more information
//* 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
//* lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
//* pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
//* entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[10];

bool nomeEncontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"\nInforme o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine()!.ToUpper();
}

Console.WriteLine($"\nInforme o nome a ser buscado: ");
string nomeBuscado = Console.ReadLine()!.ToUpper();

//* processamento
foreach (string nome in nomes)
{
    if (nome == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}

//* saída
if (nomeEncontrado == true)
{
    Console.WriteLine($"\nEncontrado!");
}
else
{
    Console.WriteLine($"\nNão encontrado!");
}

string resultadoBusca = nomeEncontrado == true ? "\nEncontrado!" : "\nNão encontrado!";
Console.WriteLine(resultadoBusca);

Console.WriteLine(nomeEncontrado == true ? "\nEncontrado!" : "\nNão encontrado!");
