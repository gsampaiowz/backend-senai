namespace _3
{
    public class JogadorAtaque : Jogador
    {
        public int IdadeAposentadoria { get; set; } = 35;
        public override void CalcularAposentadoria()
        {
            AnosAposentadoria = IdadeAposentadoria - Idade;
            Console.WriteLine($"\nAnos para se aposentar: {AnosAposentadoria}");
        }

        public override void CalcularIdade()
        {
            DateTime now = DateTime.Now;
            int anoAtual = now.Year;
            int anoNascimento = DataNascimento.Year;
            Idade = anoAtual - anoNascimento;
        }

        public override void MostrarDados()
        {
            Console.WriteLine($"\nDigite o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine($"\nDigite a data de nascimento: (dd/mm/aaaa)");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"\nDigite o nacionalidade: ");
            Nacionalidade = Console.ReadLine();
            Console.WriteLine($"\nDigite o altura: ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nDigite o peso: ");
            Peso = float.Parse(Console.ReadLine());

            Console.WriteLine(@$"
            Nome: {Nome}
            Data de Nascimento: {DataNascimento}
            Nacionalidade: {Nacionalidade}
            Altura: {Altura}
            Peso: {Peso}");
        }
    }
}