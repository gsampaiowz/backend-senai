using System.ComponentModel.DataAnnotations; //Acessando a biblioteca DataAnnotations

namespace projeto_gamer.Models
{
    public class Equipe
    {
        //propriedades
        [Key] //Data Annotation para definir como chave primária
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        public ICollection<Jogador> Jogador { get; set; }
    }
}