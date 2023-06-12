using Microsoft.AspNetCore.Mvc;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        //Instância do objeto da classe Context
        Context c = new Context();

        //                               controller/action
        [Route("Listar")]//http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            //"mochila" que contém a lista das equipes
            //Podemos usar essa mochila na View de equipe
            ViewBag.Equipe = c.Equipe.ToList();
            //Retorna a View da classe Equipe
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            //Vem como string
            // novaEquipe.Imagem = form["Imagem"].ToString();

            //Aqui começa a lógica do upload de imagem
            if (form.Files.Count > 0)
            {
                //Armazena o arquivo da imagem
                var file = form.Files[0];
                //Encontra a pasta do projeto
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
                //Verifica se a pasta existe
                if (!Directory.Exists(folder))
                {
                    //Cria a pasta
                    Directory.CreateDirectory(folder);

                }
                //
                var path = Path.Combine(folder, file.FileName);
                //
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //Copia para o caminho
                    file.CopyTo(stream);
                }
                //Atribui nome do arquivo da imagem
                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            c.Equipe.Add(novaEquipe);
            //c.Add(novaEquipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                Equipe equipeExcluida = c.Equipe.First(equipeBuscada => equipeBuscada.IdEquipe == id);

                c.Equipe.Remove(equipeExcluida);

                c.SaveChanges();

                return LocalRedirect("~/Equipe/Listar");
            }
            catch (System.Exception)
            {
                // TODO
                return LocalRedirect("~/Equipe/Erro");
            }
        }

        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Equipe equipeBuscada = c.Equipe.First(equipeBuscada => equipeBuscada.IdEquipe == id);

            ViewBag.Equipe = equipeBuscada;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Equipe equipeBuscada)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = equipeBuscada.Nome;

            //upload da imagem da equipe atualizada
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }



            Equipe equipe = c.Equipe.First(x => x.IdEquipe == equipeBuscada.IdEquipe);

            equipe.Nome = novaEquipe.Nome;
            equipe.Imagem = novaEquipe.Imagem;

            c.Equipe.Update(equipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Erro");
        }
    }
}