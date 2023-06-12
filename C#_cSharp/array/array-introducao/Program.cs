// See https://aka.ms/new-console-template for more information

//* SEM ARRAY

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"\nDigite o nome do carro: ");
// carro1 = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carro2 = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carro3 = Console.ReadLine()!;

// Console.WriteLine($"\n{carro1}, {carro2}, {carro3}");

//* COM ARRAY

// string[] carros = new string[3];

// Console.WriteLine($"\nDigite o nome do carro: ");
// carros[0] = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carros[1] = Console.ReadLine()!;
// Console.WriteLine($"\nDigite o nome do carro: ");
// carros[2] = Console.ReadLine()!;

//? SEM REPETIDOR

// Console.WriteLine($"\nPrimeiro carro da lista: {carros[0]}");
// Console.WriteLine($"\nSegundo carro da lista: {carros[1]}");
// Console.WriteLine($"\nTerceiro carro da lista: {carros[2]}");

// string[] carros = new string[3];

// //* SOLICITANDO ARRAY

// for (int i = 0; i <= 2; i++)
// {
//     Console.WriteLine($"\n Digite o nome do {i + 1}º carro da lista: ");
//     carros[i] = Console.ReadLine()!;
// }

// //* MOSTRANDO ARRAY COM FOR
// for (int i = 0; i < carros.GetLength(0); i++)
// {
//     Console.WriteLine($"\n{i + 1}º carro: {carros[i]} ");
// }

//* MOSTRANDO ARRAY COM FOR EACH

// foreach (var item in carros)
// {
//     Console.WriteLine($"\n Nome do carro: {item}");
// }

//* Criar um programa em c# que receba 5 numeros inteiros e ao final exiba o seu dobro
// Vc deve utilizar a estrutura array com tamanho 5 para o armazenamento dos numeros, a estrutura for para a leitura dos numeros e a estrutura foreach para exibi-los

// int[] numeros = new int[5];
// int[] numeros = new int[5];

// for (var i = 0; i < numeros.GetLength(0); i++)
// for (var i = 0; i < numeros.GetLength(0); i++)
// {
//     Console.WriteLine($"\nDigite o {i + 1}º número: ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
// }

// // foreach (int numero in numeros)
// // {
// //     Console.WriteLine($"\n O dobro de {numero} é {numero * 2}!");
// // }

/// for (int i = 0; i < numeros.GetLength(0); i++)
//// {

//     Console.WriteLine($"\n{i+1}. O dobro de {numeros[i]} é {numeros[i] * 2}!");
//     Console.WriteLine($"\nDigite o {i + 1}º número: ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
// }

// // foreach (int numero in numeros)
// // {
// //     Console.WriteLine($"\n O dobro de {numero} é {numero * 2}!");
// // }

/// for (int i = 0; i < numeros.GetLength(0); i++)
//// {

//     Console.WriteLine($"\n{i+1}. O dobro de {numeros[i]} é {numeros[i] * 2}!");
// }

string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] datas = new string[2];

for (int i = 0; i < nomes.Length; i++)
{
    CadastrarPassagens(nomes, origens, i);
}
for (int i = 0; i < nomes.Length; i++)
{
    ListarPassagens(nomes, origens, i);
}

// Aqui a passagem de parâmetros do array nomes veio por referência!!!!!!!!!!
static void CadastrarPassagens(string[] ns, string[] os, int pos)
{
    Console.WriteLine($"Digite o nome do {pos + 1}º:");
    ns[pos] = Console.ReadLine()!;
    Console.WriteLine($"Digite o origem do {pos + 1}º:");
    os[pos] = Console.ReadLine()!;
}
static void ListarPassagens(string[] ns, string[] os, int pos)
{
    Console.WriteLine($"Nome do {pos + 1}º: {ns[pos]}");
    Console.WriteLine($"Origem do {pos + 1}º: {os[pos]}");
}




