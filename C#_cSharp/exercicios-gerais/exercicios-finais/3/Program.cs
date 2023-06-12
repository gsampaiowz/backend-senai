// See https://aka.ms/new-console-template for more information
/*
*3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
*preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
*desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
*- Se quantidade &lt;= 5 o desconto será de 2%
*- Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
*- Se quantidade &gt; 10 o desconto será de 5%
*Dica: utilize if / else if / else
*/

Console.WriteLine($"\nDigite o nome do produto:");
string nome = Console.ReadLine()!;

Console.WriteLine($"\nDigite a quantidade a ser adquirida:");
int quantidade = int.Parse(Console.ReadLine()!);

while (quantidade < 0)
{
    Console.WriteLine($"\nDigite um valor positivo seu merda!");
    quantidade = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\nDigite o valor do preço unitário:");
float preco = float.Parse(Console.ReadLine()!);

while (preco < 0)
{
    Console.WriteLine($"\nDigite um valor positivo seu merda!");
    preco = int.Parse(Console.ReadLine()!);
}

float total = quantidade * preco;

Console.WriteLine($"\nO valor total é: R$ {total}");

float desconto = 0;

if (quantidade <= 5)
{
    desconto = (float)2 / 100;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = (float)3 / 100;
}
else if (quantidade > 10)
{
    desconto = (float)5 / 100;
}

float porcento = desconto * 100;
float final = total - (total * desconto);

Console.WriteLine($"Com o desconto de {porcento}%, o preço final do produto: {nome} é de: R$ {final}");

