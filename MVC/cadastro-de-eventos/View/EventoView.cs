using cadastro_de_eventos.Model;
using cadastro_de_eventos.Controller;

namespace cadastro_de_eventos.View
{
    public class EventoView
    {

        List<Evento> eventos = evento.Ler();

        public void MostrarMenu()
        {
            //Instância do contolador
            EventoController controlador = new EventoController();
            string opcao;
            do
            {
                Console.WriteLine(@$"
            MENU
            [1] Cadastrar evento
            [2] Listar eventos
            [3] Remover evento
            [4] Editar evento
            [0] Encerrar programa");
                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        controlador.CadastrarEvento();
                        break;
                    case "2":
                        controlador.ListarEventos();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "0":
                        Console.WriteLine($"\nEncerrando programa...");
                        Thread.Sleep(1000);
                        Console.WriteLine($"\nPrograma encerrado");

                        break;
                    default:
                        Console.WriteLine($"\nOpção inválida!");
                        break;
                }
            } while (opcao != "0");


        }

        //método para exibir os dados da lista no console
        public void Listar(List<Evento> eventos)
        {
            Console.WriteLine($"\nLista de eventos:");

            foreach (var evento in eventos)
            {
                Console.WriteLine(@$"
            Nome: {evento.Nome}
            Descrição: {evento.Descricao}
            Data: {evento.Data}");

            }
        }
        //método para cadastrar dados
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"\nPágina de cadastro");
            Console.WriteLine($"\nDigite o código do evento:");
            novoEvento.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"\nDigite o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            Console.WriteLine($"\nDigite a descrição do evento:");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;
        }

        //método para deletar dados
        public void Deletar(int codigo)
        {
            Evento removido = eventos
        }
    }
}