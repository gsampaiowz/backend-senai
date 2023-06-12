// See https://aka.ms/new-console-template for more information
/*
* Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
* ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
*/

Console.WriteLine($"\nQual o seu ano de nascimento?");
int anoNascimento = int.Parse(Console.ReadLine()!);

DateTime current_year = DateTime.Now;
int currentYear = current_year.Year;

int idade = currentYear - anoNascimento;

Console.WriteLine($"\nVocê tem {idade} anos.");


if (idade > 0 && idade < 16)
{
    Console.WriteLine($"\nNão pode votar. A idade mínima para votar é de 16 anos.");
}
else if (idade >= 16 && idade < 18)
{
    Console.WriteLine($"\nVoto opcional!");
}
else if (idade >= 18)
{
    Console.WriteLine($"\nVoto obrigatório!");
}
else
{
    Console.WriteLine($"Sua idade não pode ser um valor negativo!");
}