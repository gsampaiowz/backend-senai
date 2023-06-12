namespace projeto_produto_interface
{
    public class Carrinho : ICarrinho
    {
        //propriedades
        public float Valor { get; set; }

        //criar uma lista para manipular nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"
Código: {p.Codigo}
Nome: {p.Nome}
Preço: {p.Preco:C2}");

                }
            }
            else
            {
                Console.WriteLine($"\nCarrinho vazio!");
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }
                Console.WriteLine($"\nValor total do seu carrinho é: {Valor:C2}");

            }
            else
            {
                Console.WriteLine($"\nCarrinho vazio!");
            }
        }
    }
}