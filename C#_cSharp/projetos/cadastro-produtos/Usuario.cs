namespace cadastro_produtos
{
    public class Usuario
    {
        //Propriedades
        public int Codigo { get; set; }
        public static string Nome { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Usuario> users = new List<Usuario>();
        //Métodos
        public Usuario(string _nome, string _email, string _senha)
        {
            Codigo += 1;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Today;
        }
        public Usuario()
        {
            if (Nome == string.Empty)
            {
                Cadastrar();
            }
        }
        public void Cadastrar()
        {
            Console.WriteLine($"\nDigite seu nome:");
            string nomeDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite seu email:");
            string emailDigitado = Console.ReadLine();

            Console.WriteLine($"\nDigite a senha:");
            string senhaDigitada = Console.ReadLine();

            Nome = nomeDigitado;
            this.Email = emailDigitado;
            this.Senha = senhaDigitada;
            DataCadastro = DateTime.Now;

            //ADD
        }
        public void Deletar(Usuario usuario)
        {
            users.Remove(usuario);
        }
    }
}