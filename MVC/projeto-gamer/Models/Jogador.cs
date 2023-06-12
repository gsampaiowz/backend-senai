using System.ComponentModel.DataAnnotations; //Acessando a biblioteca DataAnnotations
using System.ComponentModel.DataAnnotations.Schema; //Acessando a biblioteca Schema de DataAnnotations 

namespace projeto_gamer.Models
{
    public class Jogador
    {
        //propriedades
        [Key] //Data Annotation para definir como chave primária
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [ForeignKey("Equipe")] // Data Annotation para definir chave estrangeira e de qual classe está herdando
        public int IdEquipe { get; set; }
        public Equipe Equipe { get; set; }
    }
}