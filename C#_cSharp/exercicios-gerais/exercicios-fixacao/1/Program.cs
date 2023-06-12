// See https://aka.ms/new-console-template for more information

//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

//? solicita e guarda salario, solicita e guarda totalGasto / se totalGasto for maior que salario, exibir "Orçamento estourado", já se for menor ou igual, exibir "Gastos dentro do orçamento"

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
                    PROGRAMA PARA CALCULAR SE O GASTO TOTAL ULTRAPASSOU O SALÁRIO OU NÃO
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Digite o valor do seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor gasto no total: ");
float totalGasto = float.Parse(Console.ReadLine()!);

if (totalGasto > salario)
{
    Console.WriteLine($"Orçamento estourado!");
}
else
{
    Console.WriteLine($"Gastos dentro do orçamento!");
}

Console.ResetColor();