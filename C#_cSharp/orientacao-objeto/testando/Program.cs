using teste;

Aluno aluno = new Aluno();

Console.WriteLine($"\nInforme a nota 1: ");
float nota1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"\nInforme a nota 2: ");
float nota2 = float.Parse(Console.ReadLine()!);

//* 1º forma de calcular a média
// float media = (nota1 + nota2) / 2;

// Console.WriteLine($"\nA média é {media}");

//* 2º forma de calcular a média
// Console.WriteLine($"\nA média é {CalcularMedia(nota1, nota2)}");

// static float CalcularMedia(float n1, float n2)
// {
//     return (n1 + n2) / 2;
// }

//* 3º forma de calcular a média
Console.WriteLine($"\n A média é {aluno.CalcularMedia()}");
