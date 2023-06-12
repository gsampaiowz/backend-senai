namespace projeto_produto_interface
{
    public interface ICarrinho
    {
        //regras do "contrato"
        //métodos que deverão aqui ser declarados apenas

        //CRUD : Create, Read, Update, Delete

        //CREATE
        void Adicionar(Produto _produto);

        //READ
        void Listar();

        //UPDATE
        void Atualizar(int _codigo, Produto _novoProduto);

        //DELETE
        void Remover(Produto _produto);
    }
}