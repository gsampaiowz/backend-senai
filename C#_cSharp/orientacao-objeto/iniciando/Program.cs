using Classe_Space;

Classe1 eu = new Classe1();

Console.WriteLine($"Qual o meu nome?");
eu.nome = Console.ReadLine()!;

Console.WriteLine($"\n{eu.nome}");

eu.Estudar();