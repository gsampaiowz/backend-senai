// See https://aka.ms/new-console-template for more information

//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
            PROGRAMA PARA CALCULAR SE A SENHA DIGITADA EQUIVALE A CORRETA OU NÃO
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Digite a senha: ");
int senha = int.Parse(Console.ReadLine()!);


if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO!");

}
else
{
    Console.WriteLine($"ACESSO NEGADO!");
}

Console.ResetColor();
