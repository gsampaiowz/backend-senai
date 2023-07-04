namespace _1
{
    public class Elevador
    {
        public int AndarAtual { get; set; } = 0;
        public int TotalAndares { get; set; }
        public int Capacidade { get; set; }
        public int PessoasDentro { get; set; }

        public Elevador(int _capacidade, int _totalAndares)
        {
            this.Capacidade = _capacidade;
            this.TotalAndares = _totalAndares;
        }
        public void Entrar()
        {
            if (this.PessoasDentro < this.Capacidade)
            {
                PessoasDentro++;
            }
            else
            {
                Console.WriteLine($"\nO elevador já atingiu a capacidade máxima. Enter para voltar ao menu.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public void Sair()
        {
            if (this.PessoasDentro > 0)
            {
                PessoasDentro--;
            }
            else
            {
                Console.WriteLine("\nO elevador já está vazio. Enter para voltar ao menu.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public void Subir()
        {
            if (this.AndarAtual < this.TotalAndares)
            {
                AndarAtual++;
            }
            else
            {
                Console.WriteLine($"\nEsse é o último andar! Enter para voltar ao menu.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public void Descer()
        {
            if (this.AndarAtual > 0)
            {
                AndarAtual--;
            }
            else
            {
                Console.WriteLine($"\nEsse é o andar térreo! Enter para voltar ao menu.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
    }
}