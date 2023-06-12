namespace cadastro_de_eventos.Model
{
    public class Evento
    {
        //propriedades 
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateOnly Data { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        //caminho da pasta e do arquivo CSV
        private const string PATH = "Database/Produto.csv";

        //métodos
        public Evento()
        {
            //criando lógica para gerar a pasta e o arquivo
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

            //métodos para ler os dados do arquivo csv

        }
        public List<Evento> Ler()
        {
            //instância da lista
            List<Evento> eventos = new List<Evento>();

            //array de strings armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            //leitura das linhas
            foreach (var linha in linhas)
            {
                //separação de propriedades de cada linha
                string[] propriedades = linha.Split(";");

                //instância de objeto
                Evento evento = new Evento();

                //atribuição de valores dentro do objeto
                evento.Nome = propriedades[0];
                evento.Descricao = propriedades[1];
                evento.Data = DateOnly.Parse(propriedades[2]);

                //adiciona objeto dentro da lista
                eventos.Add(evento);
            }

            //retorna a lista
            return eventos;
        }

        //método para preparar as linhas a serem inseridas no csv
        public string PrepararLinhasCsv(Evento evento)
        {
            return $"{evento.Nome};{evento.Descricao};{evento.Data}"; //Nome;Descricao;Data
        }

        //método para inserir um item na linha do csv
        public void Inserir(Evento evento)
        {
            string[] linhas = { PrepararLinhasCsv(evento) };

            File.AppendAllLines(PATH, linhas);
        }
    }
}