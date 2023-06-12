namespace programa_contato
{
    public interface IAgenda
    {
        //regras de contrato!
        void Adicionar(Contato _contato);
        void Listar();
    }
}