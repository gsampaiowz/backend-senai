// See https://aka.ms/new-console-template for more information
//*  3. Salário: maior que zero;

Console.WriteLine($"DIGITE O SEU SALÁRIO!");
float salario = float.Parse(Console.ReadLine()!);

while (salario < 0)
{
    Console.WriteLine($"NÃO EXISTE SALÁRIO NEGATIVO IRMÃO! DIGITE NOVAMENTE: ");
    salario = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"TA RICO EM PARCEIRO!! SLCC");


