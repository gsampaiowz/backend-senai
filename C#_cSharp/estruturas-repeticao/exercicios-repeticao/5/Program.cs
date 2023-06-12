// See https://aka.ms/new-console-template for more information
/*
5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
A.Total de Homens;      
B.Total de Mulheres;      
C.Média de idade dos Homens;      
D.Média de idade das Mulheres.
E.Média de peso dos Homens;
F.Média de peso dos Mulheres.

!ALGORITMO
VAR: idade, peso, sexo, idadeHomens, pesoHomens, idadeMulheres, pesoMulheres, homens, mulheres, mediaIdadeHomens, mediaIdadeMulheres, mediaPesoHomens, mediaPesoMulheres
    Iterador para 10 pessoas que receba
        idade
        peso
        sexo
    idade += idade
    peso += peso
    SE sexo == masculino => homens++; pesoHomens += peso; idadeHomens += idade;
    JA SE sexo == feminino => mulheres++; pesoMulheres += peso; idadeMulheres += idade; 
    SENAO => erro;
    total = homens + mulheres;
    mediaPesoTotal = peso / total;
    mediaPesoHomens = pesoHomens / homens ;
    mediaPesoMulheres = pesoMulheres / mulheres;
    mediaIdadeHomens = idadeHomens / homens;
    mediaIdadeMulheres = idadeMulheres / mulheres;
*/

Console.ForegroundColor = ConsoleColor.DarkCyan;

float peso = 0;
int idade = 0;
int idadeTodos = 0;
float pesoTodos = 0;
int idadeHomens = 0;
float pesoHomens = 0;
int idadeMulheres = 0;
float pesoMulheres = 0;
int homens = 0;
int mulheres = 0;

Console.WriteLine($"Pesquisa: ");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\nEntrevistando pessoa {i}. \n Qual o seu sexo? M para MASCULINO ou F para FEMININO: ");
    char sexo = char.Parse(Console.ReadLine()!.ToUpper());

    while (sexo != 'F' && sexo != 'M')
    {
        Console.WriteLine($"\n Resposta inválida. Por favor digite M para MASCULINO ou F para FEMININO: ");
        sexo = char.Parse(Console.ReadLine()!.ToUpper());
    }

    Console.WriteLine($"\n Qual o seu peso? ");
    peso = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"\n Qual a sua idade? ");
    idade = int.Parse(Console.ReadLine()!);

    if (sexo == 'F')
    {
        mulheres++;
        pesoMulheres += peso;
        idadeMulheres += idade;
    }
    else
    {
        homens++;
        pesoHomens += peso;
        idadeHomens += idade;
    }

    pesoTodos += peso;
    idadeTodos += idade;
}

float mediaIdadeHomens = 0;
float mediaPesoHomens = 0;
float mediaIdadeMulheres = 0;
float mediaPesoMulheres = 0;

if (homens == 0)
{
    mediaIdadeHomens = 0;
    mediaPesoHomens = 0;
    mediaIdadeMulheres = idadeMulheres / mulheres;
    mediaPesoMulheres = pesoMulheres / mulheres;
}
else if (mulheres == 0)
{
    mediaIdadeMulheres = 0;
    mediaPesoMulheres = 0;
    mediaIdadeHomens = idadeHomens / homens;
    mediaPesoHomens = pesoHomens / homens;
}
else
{
    mediaIdadeMulheres = idadeMulheres / mulheres;
    mediaPesoMulheres = pesoMulheres / mulheres;
    mediaIdadeHomens = idadeHomens / homens;
    mediaPesoHomens = pesoHomens / homens;
}

int totalPessoas = homens + mulheres;
float mediaPesoTotal = pesoTodos / totalPessoas;
float mediaIdadeTotal = idadeTodos / totalPessoas;

Console.WriteLine($"\n      RESULTADO FINAL DA PESQUISA! \n No total foram {totalPessoas} pessoas entrevistadas; \n Desse todo, {homens} se disseram de sexo masculino, e {mulheres} se disseram de sexo feminino; \n A média de peso entre todas as pessoas é de: {mediaPesoTotal} \n Entre os homens: {mediaPesoHomens} \n Entre as mulheres:{mediaPesoMulheres} \n A média de idade entre todas as pessoas é de: {mediaIdadeTotal} \n Entre os homens: {mediaIdadeHomens} \n Entre as mulheres: {mediaIdadeMulheres}");


Console.ResetColor();