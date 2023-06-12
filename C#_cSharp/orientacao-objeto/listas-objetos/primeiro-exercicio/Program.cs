//Crie uma classe Produto
//Com as propriedades : int Código, string Nome, float Preco
//Crie um construtor vazio
//Crie um construtor completo

using primeiro_ex;

//Criar a lista de objetos(produtos)

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(1234, "camisa do corinthians", 190)
);

produtos.Add(
    new Produto()
);

produtos.Add(
    new Produto(4321, "camisa do vasco", 189.99f)
);

Produto camisaPalmeiras = new Produto(1212, "camisa do torneiras", 10);
produtos.Add(camisaPalmeiras);

foreach (var item in produtos)
{
    Console.WriteLine($"\nLISTA ANTIGA \nCódigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C2}, Índice:{produtos.IndexOf(item)}");
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 1234);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 200;

Console.ReadKey();

Console.WriteLine($"\nCódigo buscado: {produtoBuscado.Codigo}, Nome buscado:{produtoBuscado.Nome}, Preço buscado:{produtoBuscado.Preco:C2} , Índice: {index}");

produtos.RemoveAt(index);

foreach (var item in produtos)
{
    Console.WriteLine($"\nLISTA APÓS REMOVER\nCódigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C2}, Índice:{produtos.IndexOf(item)}");
}

produtos.Insert(index, produtoBuscado);

Console.ReadKey();

foreach (var item in produtos)
{
    Console.WriteLine($"\nLISTA APÓS INSERIR\nCódigo: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C2}, Índice:{produtos.IndexOf(item)}");
}