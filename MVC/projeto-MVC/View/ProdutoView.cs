using projeto_MVC.Model;

namespace projeto_MVC.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista no console
        public void Listar(List<Produto> produtos)
        {
            Console.WriteLine($"\nLista de produtos");

            foreach (var produto in produtos)
            {
                Console.WriteLine(@$"
                Código: {produto.Codigo}
                Nome: {produto.Nome}
                Preço: {produto.Preco:C2}");

            }
        }
        //método para cadastrar dados
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"\nPágina de cadastro");
            Console.WriteLine($"\nDigite o código:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"\nDigite o nome:");
            novoProduto.Nome = Console.ReadLine();
            Console.WriteLine($"\nDigite o preço:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;

        }
    }
}