//* myVar = CamelCase
//* MyMethod = PascalCase

// static void BomDia()
// {
//     Console.WriteLine($"\nBom dia!");
// }

// static void BoaTarde()
// {
//     Console.WriteLine($"\nBoa tarde!");
//     //?variáveis
//     //?condicionais
//     //?repetições
//     //?arrays
// }

// static string BoaNoite()
// {
//     return $"\nBoa noite!";
// }

// static string[] BoaNoite()
// {
//     string[] saudacao = new string[2];
//     saudacao[0] = "Boa";
//     saudacao[1] = "noite!";
//     return saudacao;
// }

// BomDia();
// BoaTarde();
// Console.WriteLine(BoaNoite());

// string[] batatinha = BoaNoite();
// Console.WriteLine(batatinha);

// string texto = ($"{BoaNoite()[0]} {BoaNoite()[1]}");
// Console.WriteLine(texto);

int[] numeros = new int[] {999,2,1,458,54};
                        //  0  1 2  3  4
Console.WriteLine($"{numeros.GetValue(3)}");

string[] nomes = new string[] {"Carlos","Edu","EU"};
                            //     0      1
Console.WriteLine($"{nomes.Max()}");

//? .Max  .Min   .Contains   .GetValue
