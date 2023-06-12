namespace cadastro_produtos
{
    public class Marca
    {
        //Propriedades
        public int Codigo { get; set; } = 0;
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public static List<Marca> ListaDeMarcas = new List<Marca>();
        //Métodos
        public Marca(int _codigo, string _nomeMarca)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Today;
        }

        public Marca()
        {
        }

        public static void Cadastrar()
        {
            Console.WriteLine($"\nDigite o código da marca:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o nome da marca:");
            string nome = Console.ReadLine();

            ListaDeMarcas.Add(new Marca(codigo, nome));
        }
        public static void Listar()
        {
            if (ListaDeMarcas.Count > 0)
            {
                foreach (Marca marca in ListaDeMarcas)
                {
                    Console.WriteLine(@$"
                    Lista de Marcas
                    Código: {marca.Codigo}
                    Nome: {marca.NomeMarca}
                    Data de cadastro: {marca.DataCadastro}");

                }
            }
        }
        public static void Deletar(int codigo)
        {
            Marca removida = ListaDeMarcas.Find(x => x.Codigo == codigo);
            int index = ListaDeMarcas.IndexOf(removida);
            ListaDeMarcas.RemoveAt(index);

            Console.WriteLine($"\nMarca sumiu.");

        }
    }
}