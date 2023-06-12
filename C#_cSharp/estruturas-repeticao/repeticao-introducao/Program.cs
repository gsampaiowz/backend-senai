// See https://aka.ms/new-console-template for more information

//! Estruturas de repetição 


// int i = 1;

// while (i <= 10)
// {
//     Console.WriteLine(i);
//     i += 1; //* INCREMENTO COMPOSTO : i = i + num
//     i++; //* INCREMENTO SIMPLES : i = i + 1

// }

//! EXEMPLO WHILE

// Console.ForegroundColor = ConsoleColor.Green;

// bool idadeCerta = false;

// while (idadeCerta == false) //* (!(idadeCerta == true))
// {
//     Console.WriteLine($"Qual a idade do CR7?");
//     int idade = int.Parse(Console.ReadLine()!);

//     if (idade == 38)
//     {
//         idadeCerta = true;
//     }

// }

// Console.ResetColor();

//! EXEMPLO LOGIN

// Console.WriteLine($"Informe o nome do usuário: ");
// string nome = Console.ReadLine()!;

// Console.WriteLine($"Informe a senha do usuário: ");
// string senha = Console.ReadLine()!;

// while (senha.Length != 6)
// {
//     Console.WriteLine($"Informe a senha novamente, tem que ter 6 caracteres.");
//     senha = Console.ReadLine()!;

// }

// Console.WriteLine($"Usuário e senha recebidos com sucesso!");

//! EXEMPLO DO-WHILE

// Console.ForegroundColor = ConsoleColor.Red;

// idadeCerta = false;

// do
// {
//     Console.WriteLine($"Qual a idade do CR7?");
//     int idade = int.Parse(Console.ReadLine()!);

//     if (idade == 38)
//     {
//         Console.WriteLine($"ACERTOU!");

//         idadeCerta = true;
//     }
//     else
//     {
//         Console.WriteLine($"ERROU PARCEIRO");

//     }

// } while (idadeCerta == true);

// Console.ResetColor();

//! EXEMPLO FOR 

// for (inicializador; condição; iterador)
// {
//     bloco de código
// }

// for (int x = 0; x <= 100; x += 3)
// {
//     Console.WriteLine(x);

// }

for (int x = 500; x >= 0; x -= 5)
{
    Console.WriteLine(x);
}