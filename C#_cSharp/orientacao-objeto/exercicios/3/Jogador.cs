namespace _3
{
    public abstract class Jogador
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public int Idade { get; set; }
        public int AnosAposentadoria { get; set; }

        public abstract void MostrarDados();
        public abstract void CalcularIdade();
        public abstract void CalcularAposentadoria();
    }
}