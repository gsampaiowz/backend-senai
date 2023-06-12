namespace Classe_Space
{
    public class Classe1
    {
        //atributos

        public string nome = "Sampaio";
        public string idade = "17 anos";
        public string altura = "1,69 m";
        public string ocupacao = "Estudante/Aluno";

        //métodos

        public void JogarBola()
        {
            Console.WriteLine($"\n{nome} jogou bola!");
        }
        public void JogarTerraria()
        {
            Console.WriteLine($"\n{nome} jogou Terraria!");
        }
        public void Estudar()
        {
            Console.WriteLine($"\n{nome} estudou!");
        }

    }
}