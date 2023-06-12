namespace programa_contato
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        //propriedades
        public string Cpf { get; set; }

        public bool ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}