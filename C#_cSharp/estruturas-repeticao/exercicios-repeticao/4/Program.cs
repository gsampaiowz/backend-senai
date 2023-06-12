// See https://aka.ms/new-console-template for more information
/* 
4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
A.O número de pessoas que responderam SIM.
B.O número de pessoas que responderam NÃO;
C.O número de mulheres que responderam SIM;
D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

! ALGORITMO
    VARS: respostaSIM, respostaNAO, mulheresNAO, porcentagemHomensNAO 
    Iterador de 10 vezes com as perguntas "Gostou do produto? [S/N]" e "Qual o seu sexo? [M/F]" 
    SE produto == sim, respostaSIM++ JA SE produto == nao, respostaNAO++ SENAO erro
    SE sexo == masculino, respostaHomens++ JA SE sexo == feminino, respostaMulheres++ SENAO erro
    SE sexo == feminino && produto == nao, mulheresNAO++ JA SE sexo == masculino && produto == nao, homensNAO++

    respostaHomens      5 100 => 5x = 100 * 2 => x = 100 * 2 / 5
    homensNAO   2  x
*/

//! INICIO

Console.ForegroundColor = ConsoleColor.DarkMagenta;

//? ENTRADA DE DADOS
int respostaSIM = 0;
int respostaNAO = 0;
int respostaHomens = 0;
int respostaMulheres = 0;
int mulheresNAO = 0;
int homensNAO = 0;

Console.WriteLine($"\nPesquisa de Mercado:");

for (int i = 1; i <= 4; i++)
{

    Console.WriteLine($"\n Entrevistando pessoa {i}. Para obtenção de dados estatísticos, qual seu sexo? Digite F para FEMININO ou M para MASCULINO: ");
    char sexo = char.Parse(Console.ReadLine()!.ToUpper());

    while (sexo != 'M' && sexo != 'F')
    {
        Console.WriteLine($"\nResposta inválida, por favor digite M ou F!");
        sexo = char.Parse(Console.ReadLine()!.ToUpper());
    }

    if (sexo == 'M')
    {
        respostaHomens++;
    }
    else if (sexo == 'F')
    {
        respostaMulheres++;
    }

    Console.WriteLine($"\n Você gostou do produto? Digite S para SIM ou N para NÃO: ");
    char produto = char.Parse(Console.ReadLine()!.ToUpper());

    while (produto != 'S' && produto != 'N')
    {
        Console.WriteLine($"\nResposta inválida, por favor digite S ou N!");
        produto = char.Parse(Console.ReadLine()!.ToUpper());
    }

    if (produto == 'S')
    {
        respostaSIM++;

    }
    else if (produto == 'N')
    {
        respostaNAO++;

        if (sexo == 'F')
        {
            mulheresNAO++;
        }
        else if (sexo == 'M')
        {
            homensNAO++;
        }
        else { }
    }

}

double porcentagemHomensNAO = 0;
double porcentagemMulheresNAO = 0;

if (respostaHomens == 0)
{
    porcentagemHomensNAO = 0;
    porcentagemMulheresNAO = Math.Round(100 * (double)mulheresNAO / (double)respostaMulheres, 2);
}
else if (respostaMulheres == 0)
{
    porcentagemMulheresNAO = 0;
    porcentagemHomensNAO = Math.Round(100 * (double)homensNAO / (double)respostaHomens, 2);
}
else
{
    porcentagemMulheresNAO = Math.Round((double)100 * mulheresNAO / respostaMulheres, 2);
    porcentagemHomensNAO = Math.Round((double)100 * homensNAO / respostaHomens, 2);
}

int totalRespostas = respostaSIM + respostaNAO;

Console.WriteLine($"\n     RESULTADO FINAL DA PESQUISA: \n Total de Respostas:{totalRespostas} \n Mulheres: {respostaMulheres} \n Homens: {respostaHomens} \n Mulheres que responderam NÃO: {mulheresNAO} \n Homens que responderam NÃO: {homensNAO} \n Porcentagem de homens que responderam NÃO: {porcentagemHomensNAO}% \n Porcentagem de mulheres que responderam NÃO: {porcentagemMulheresNAO}% ");

Console.ResetColor();

//! FIM