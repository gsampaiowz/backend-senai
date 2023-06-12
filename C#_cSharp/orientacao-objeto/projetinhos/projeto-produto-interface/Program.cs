//OBJETO como PARÂMETRO

using projeto_produto_interface;

//Instância do objeto carrinho
Carrinho carrinho = new Carrinho();

//Instanciar objeto(s) da classe
Produto p1 = new Produto(1, "Forza Horizon 4", 249.99f);
Produto p2 = new Produto(2, "Terraria", 29.99f);
Produto p3 = new Produto(3, "Skyrim", 129.99f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();
carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção de um item");

carrinho.Remover(p2);
carrinho.Listar();
carrinho.TotalCarrinho();

Console.WriteLine($"Após a atualização de um item");

//Criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Terraria";
_novoProduto.Preco = 19.99f;


carrinho.Atualizar(1, _novoProduto);
carrinho.Listar();
carrinho.TotalCarrinho();