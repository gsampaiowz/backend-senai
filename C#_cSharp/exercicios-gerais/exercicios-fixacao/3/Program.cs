// See https://aka.ms/new-console-template for more information

//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. Sendo    que:    − Triângulo    Equilátero:    possui    os    3    lados    iguais.− Triângulo    Isóscele:    possui    2    lados    iguais.− Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine(
    @$"
---------------------------------------------------------------------------------------------------------------
            PROGRAMA PARA CALCULAR SE UM TRIANG. É EQUILÁTERO, ISÓSCELES OU ESCALENO
---------------------------------------------------------------------------------------------------------------");

Console.WriteLine($"Digite o tamando do lado 1, em centímentros: ");
float lado1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o tamando do lado 2, em centímentros: ");
float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o tamando do lado 3, em centímentros: ");
float lado3 = float.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"É um triângulo equilátero!");

}
else if (lado1 != lado2 && (lado2 != lado3 && lado1 != lado3))
{
    Console.WriteLine($"É um triângulo escaleno!");

}
else
{
    Console.WriteLine($"É um triângulo isósceles!");

}

Console.ResetColor();
