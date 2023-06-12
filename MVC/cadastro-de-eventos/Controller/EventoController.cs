using cadastro_de_eventos.Model;
using cadastro_de_eventos.View;

namespace cadastro_de_eventos.Controller
{
    public class EventoController
    {
        //instância da Model e View
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        //método controlador para acessar a listagem dos dados
        public void ListarEventos()
        {
            //chamada da Model trazendo a lista
            List<Evento> eventos = evento.Ler();

            //chamada da View passando a lista
            eventoView.Listar(eventos);
        }
        //método controlador para acessar o cadastro dos dados
        public void CadastrarEvento()
        {
            Evento novoEvento = eventoView.Cadastrar();
            evento.Inserir(novoEvento);
        }
    }
}