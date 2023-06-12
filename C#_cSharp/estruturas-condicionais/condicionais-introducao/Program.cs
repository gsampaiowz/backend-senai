// See https://aka.ms/new-console-template for more information
// Condidional Simples

// bool sol = true;

// if (sol)
// {
//     Console.WriteLine($"Vou para a praia!");

// }

//Condicional Composta

// Console.WriteLine($"O dia está ensolarado?");
// string sol = Console.ReadLine().ToUpper();

// Console.WriteLine($"Está de folga?");
// string folga = Console.ReadLine().ToUpper();


// if ((sol == "SIM") && (folga == "SIM"))
// {
//     Console.WriteLine($"Vou para a PRAIA!");

// }
// else
// {
//     Console.WriteLine($"Eu vou ir trabalhar :)");

// }

// string nome1 = "Vitória";
// string nome2 = "Catarina";

// if (nome1 == nome2)
// {
//     Console.WriteLine($"Nomes iguais");
// }
// else
// {
//     Console.WriteLine($"Nomes diferentes");

// }

// string nomeIgual = (nome1 == nome2) ? "Nomes iguais" : "Nomes diferentes";
// Console.WriteLine(nomeIgual);


//Condicional Encadeada

Console.WriteLine($"Qual a sua idade?");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 18)
{
    Console.WriteLine($"Pode entra na festa, beba com moderação!");
}
else if (idade >= 16 && idade < 18)
{
    Console.WriteLine($"Pode entrar na festa com a mamãe!");
}
else
{
    Console.WriteLine($"Vai brincar de Max Steel!");
}
