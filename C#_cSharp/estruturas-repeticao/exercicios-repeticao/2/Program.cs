// See https://aka.ms/new-console-template for more information
//* 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(@$"
-------------------------------
Digite seu nome de usuário: ");
string nome = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine()!.ToUpper();

while (senha.Contains(nome)) //! função Contains para verificar se contem algo específico em uma variável
{
    Console.WriteLine($"Sua senha não pode conter o seu nome de usuário! Por favor digite novamente: ");
    senha = Console.ReadLine()!.ToUpper();
}

Console.WriteLine($"Perfeito!");

Console.ResetColor();
