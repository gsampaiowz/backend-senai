namespace primeiro_ex
{
    public class Produto
    {
        //construtores
        public Produto()
        {
        }
        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public float Preco { get; set; }
    }
}