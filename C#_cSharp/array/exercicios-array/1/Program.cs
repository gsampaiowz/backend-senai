// See https://aka.ms/new-console-template for more information
//* Receba e imprima o nome e idade de 5 pessoas
//* Personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < nomes.GetLength(0); i++)
{
    Console.WriteLine($"\n {i + 1}º pessoa. Digite o seu nome: ");
    nomes[i] = Console.ReadLine()!;
    Console.WriteLine($"\n {i + 1}º pessoa. Digite a sua idade: ");
    idades[i] = int.Parse(Console.ReadLine()!);

}

for (int i = 0; i < idades.GetLength(0); i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n {i + 1}º Pessoa. \n Nome: {nomes[i]}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Idade: {idades[i]}");
    Console.ResetColor();
}