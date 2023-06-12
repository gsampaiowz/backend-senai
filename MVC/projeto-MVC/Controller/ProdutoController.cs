using projeto_MVC.Model;
using projeto_MVC.View;

namespace projeto_MVC.Controller
{
    public class ProdutoController
    {
        //instância das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da Model trazendo a lista
            List<Produto> produtos = produto.Ler();

            //chamada da View passando a lista
            produtoView.Listar(produtos);

        }
        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();
            produto.Inserir(novoProduto);
        }
    }
}