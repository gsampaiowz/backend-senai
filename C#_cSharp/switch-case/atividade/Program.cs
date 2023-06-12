// See https://aka.ms/new-console-template for more information
//? Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
//? A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
//? Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine(@$"
---------------------------
|   MENU DE BEBIDAS
---------------------------
|   1. SKOL
|   2. BRAHMA
|   3. ITAIPAVA 
|   4. HEINEKEN
|   5. GIN
|   6. ASKOV
|   7. CORONA
---------------------------
");

Console.WriteLine($"Digite o número correspondente a bebida desejada: ");
int escolha = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Gostaria de acrescentar gelo? sim/não ");
string gelo = Console.ReadLine()!.ToUpper();

while (gelo != "SIM" && gelo != "NÃO")
{
    Console.WriteLine($"Por favor, digite sim ou não");
    gelo = Console.ReadLine()!.ToUpper();
}


string bebida = string.Empty;

switch (escolha)
{
    case 1:
        bebida = "Skol";
        break;
    case 2:
        bebida = "Brahma";
        break;
    case 3:
        bebida = "Itaipava";
        break;
    case 4:
        bebida = "Heineken";
        break;
    case 5:
        bebida = "Gin";
        break;
    case 6:
        bebida = "Askov";
        break;
    case 7:
        bebida = "Corona";
        break;
    default:
        Console.WriteLine($"Escolha inválida, verifique se o número digitado consta no menu de bebidas.");
        break;
}

if (gelo == "SIM")
{
    Console.WriteLine($"O seu pedido é: {bebida} com gelo adicional!");
}
else if (gelo == "NÃO")
{
    Console.WriteLine($"O seu pedido é: {bebida} sem gelo adicional.");

}

Console.ResetColor();