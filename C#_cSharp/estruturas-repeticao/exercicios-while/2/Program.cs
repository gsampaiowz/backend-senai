// See https://aka.ms/new-console-template for more information
//*  2. Idade: entre 0 e 100 anos;

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"EAI MANO TU TA CHAPANDO AS IDEIA DOIDO? DIGITA A IDADE CERTA AÍ NMRL");
    idade = int.Parse(Console.ReadLine()!);

}

Console.WriteLine($"TA NA FLOR DA IDADE HEIN IRMÃO");

