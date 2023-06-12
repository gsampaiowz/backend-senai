namespace cadastro_produtos
{
    public class Login
    {
        //Propriedades
        public bool Logado { get; set; }

        //Métodos
        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario usuario)
        {
            do
            {
                Console.WriteLine($"\nDigite seu email:");
                string emailDigitado = Console.ReadLine();

                Console.WriteLine($"\nDigite a senha:");
                string senhaDigitada = Console.ReadLine();

                if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
                {
                    this.Logado = true;
                    Console.WriteLine($"\nLogin efetuado com sucesso!");
                }
                else
                {
                    this.Logado = false;
                    Console.WriteLine($"\nDados incorretos!");
                }
            } while (this.Logado == false);
        }
        public void Deslogar(Usuario usuario)
        {
            this.Logado = false;
            Console.WriteLine($"\nDesconectado com sucesso!");

        }
        public void GerarMenu()
        {

            string opcao;

            do
            {
                Console.WriteLine(@$"
            <MENU>
            [1] - Cadastrar produto
            [2] - Listar produtos
            [3] - Remover produto
            
            [4] - Cadastrar marca
            [5] - Listar marcas
            [6] - Remover marca
            
            [0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Produto.CadastrarProduto();
                        break;
                    case "2":
                        Produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"\nInforme o código do produto que deseja remover: ");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        Produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        Marca.Cadastrar();
                        break;
                    case "5":
                        Marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"\nInforme o código da marca que deseja remover: ");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        Marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"\nSaindo da aplicação...");
                        Thread.Sleep(1000);
                        Console.WriteLine($"\nEncerrado.");
                        break;
                    default:
                        Console.WriteLine($"\nOpção inválida.");
                        break;
                }
            } while (opcao != "0");
        }


    }
}