// See https://aka.ms/new-console-template for more information

//Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
            PROGRAMA PARA CALCULAR SE O ALUNO VAI SER APROVADO, REPROVADO OU FAZER RECUPERAÇÃO
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Digite a média final do aluno: ");
float media = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a frequência final do aluno, em porcentagem: ");
float frequencia = float.Parse(Console.ReadLine()!);

frequencia = frequencia / 100;


if (media >= 7.0 && frequencia >= 0.75)
{
    Console.WriteLine($"ALUNO APROVADO!");

}
else if ((media < 7.0 && media >= 3.0) && frequencia >= 0.75)
{
    Console.WriteLine($"ALUNO EM RECUPERAÇÃO.");
}
else if ((media > 10.0 || media < 0) || (frequencia > 1.00 || frequencia < 0))
{
    Console.WriteLine($"DIGITE VALORES VÁLIDOS POR FAVOR");
}
else
{
    Console.WriteLine($"ALUNO REPROVADO.");

}

Console.ResetColor();
