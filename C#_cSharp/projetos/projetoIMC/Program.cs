// Programa IMC

//* Faça um programa que calcule o imc de uma pessoa recebendo os dados no console, e ao final imprima o resultado no console.

//! MUDA A COR DO TEXTO
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
                                      PROGRAMA PARA CALCULAR IMC                                              
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine()!);
float imc = peso / ((float)Math.Pow(altura, 2));

//* CONCATENAÇÃO
Console.WriteLine("O IMC do paciente " + nome + " é: " + imc + "!");

//* INTERPOLAÇÃO
Console.WriteLine($"O IMC do paciente {nome} é: {imc}!");
