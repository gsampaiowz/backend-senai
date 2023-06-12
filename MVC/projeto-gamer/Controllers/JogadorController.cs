using Microsoft.AspNetCore.Mvc;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        //Instância do objeto da classe Context
        Context c = new Context();

        //                               controller/action
        [Route("Listar")]//http://localhost/Jogador/Listar
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            //"mochila" que contém a lista dos Jogadores
            //Podemos usar essa mochila na View de Jogador
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();
            //Retorna a View da classe Jogador
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["Equipe"].ToString());

            c.Jogador.Add(novoJogador);
            //c.Add(novoJogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                Jogador e = c.Jogador.First(j => j.IdJogador == id);

                c.Jogador.Remove(e);

                c.SaveChanges();

                return LocalRedirect("~/Jogador/Listar");
            }
            catch (System.Exception)
            {
                // TODO
                return LocalRedirect("~/Jogador/Erro");
            }
        }
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Jogador jogadorBuscado = c.Jogador.First(jogadorBuscado => jogadorBuscado.IdJogador == id);

            ViewBag.Jogador = jogadorBuscado;
            ViewBag.Equipe = c.Equipe.ToList();

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            Jogador JogadorEditado = c.Jogador.First(x => x.IdJogador == novoJogador.IdJogador);

            JogadorEditado.Nome = novoJogador.Nome;
            JogadorEditado.Email = novoJogador.Email;
            JogadorEditado.Senha = novoJogador.Senha;
            JogadorEditado.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(JogadorEditado);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Erro");
        }
    }
}