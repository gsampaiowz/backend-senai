namespace construtores
{
    public class Produto
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public float Preco { get; set; }
        
        
        public Produto()
        {
            Console.WriteLine($"\nGOL do HAALAND!");
        }
        public Produto(string codigo)
        {
            Codigo = codigo;
        }
        public Produto(string codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}