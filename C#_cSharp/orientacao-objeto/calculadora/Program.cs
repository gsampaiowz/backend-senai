using calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.ForegroundColor = ConsoleColor.Magenta;
        string opcao;
        do
        {
            Console.WriteLine(@$"
_______________________________________________________

        Calculadora com orientação a objetos
_______________________________________________________        
");
            Console.WriteLine(@$"
        Escolha o tipo de operação:
        [1] para SOMAR
        [2] para SUBTRAIR
        [3] para MULTIPLICAR
        [4] para DIVIDIR
        [0] para SAIR
        ");
            opcao = Console.ReadLine()!;
            if (opcao != "0")
            {
                Console.WriteLine($"\nDigite o primeiro número: ");
                calc.num1 = float.Parse(Console.ReadLine()!);
                Console.WriteLine($"\nDigite o segundo número: ");
                calc.num2 = float.Parse(Console.ReadLine()!);
            }
            Console.WriteLine($"_______________________________________________________");
            float resultado;
            switch (opcao)
            {
                case "1":
                    resultado = calc.Somar();
                    Console.WriteLine($"\nO resultado é: {resultado}");
                    break;
                case "2":
                    resultado = calc.Subtrair();
                    Console.WriteLine($"\nO resultado é: {resultado}");
                    break;
                case "3":
                    resultado = calc.Multiplicar();
                    Console.WriteLine($"\nO resultado é: {resultado}");
                    break;
                case "4":
                    resultado = calc.Dividir();
                    Console.WriteLine($"\nO resultado é: {resultado}");
                    break;
                case "0":
                    Console.WriteLine($"\nEncerrando...");
                    Thread.Sleep(2000);
                    Console.WriteLine($"\nPrograma encerrado.");
                    break;
                default:
                    Console.WriteLine($"\nOpção inválida!");
                    break;
            }
        } while (opcao != "0");
        Console.ResetColor();
    }
}