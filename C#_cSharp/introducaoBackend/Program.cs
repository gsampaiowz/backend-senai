//variáveis

// declarando uma variável
// tipo nome = valor
// const string nome = "Sampaio";
// // nome = "Jeferso";
// Console.WriteLine("Nome: " + nome);

// int idade = 17;
// idade = 18;
// Console.WriteLine("Idade: " + idade);

// Console.WriteLine("A idade do " + nome + " é: " + idade+" anos!");

//tipos de dados
// int quantidade = 10;
// double preco = 4.99d;
// float altura = 1.70f;
// bool careca = true;
// string texto = "Hello world!";
// char letra = 'S';

//operadores aritmétcos

// //soma
// Console.WriteLine(4 + 4);
// Console.WriteLine(4 + "4");

// //subtração
// Console.WriteLine(10 - 5);

// //multiplicação
// Console.WriteLine(5 * 10);

// //divisão
// Console.WriteLine(10 / 5);

// //modular
// Console.WriteLine(5 % 2);

// //integer
// Console.WriteLine(5 / 2);

// //potency
// Console.WriteLine(Math.Pow(2, 5));

//operadores de comparação - resposta true ou false

// //igual a
// Console.WriteLine(5 == 6);

// //maior ou igual a
// Console.WriteLine(5 >= 4);

// //menor ou igual a
// Console.WriteLine(4 <= 3);

// //maior que
// Console.WriteLine(9 > 10);

// //menor que
// Console.WriteLine(0.1 < 1);

// //diferente de
// Console.WriteLine(10 != 10);

// //operadores lógicos e tabela verdade

// //&& : e
// //|| : ou
// // ! : negação

// Console.WriteLine(5 == 5 && 8 == 8); //*TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 9); //*TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8); //*FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 9); //*FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 4 == 4); //*TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 4 == 5); //*TRUE || FALSE = TRUE
// Console.WriteLine(2 == 3 || 4 == 4); //*FALSE || TRUE = TRUE
// Console.WriteLine(2 == 3 || 4 == 5); //*FALSE || FALSE = FALSE

// Console.WriteLine(!(1 == 1) && 7 == 7); //? TRUE -> FALSE && TRUE = FALSE

// //Crie um programa para calcular o IMC de uma pessoa

// string nome = "Sampaio";
// float peso = 56.6f;
// float altura = 1.70f;

// //processamento
// float imc = peso / (altura * altura);

// //saida
// Console.WriteLine($"O IMC do " + nome + " é de: " + Math.Round(imc, 2));

// INCREMENTOS

// int contador = 10;

// // contador = contador +?;

// contador /= 5;

// Console.WriteLine(contador);

// //MÉTODO QUE RETORNA VALOR DO PI = Math.PI

// Console.WriteLine(Math.PI);

//MÉTODOS MÁXIMO E MÍNIMO DOS VALORES
Console.WriteLine(Math.Max(5,10));
Console.WriteLine(Math.Min(10,50));
