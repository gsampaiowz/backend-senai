namespace teste
{
    public class Aluno
    {
        public float nota1;
        public float nota2;

        public float CalcularMedia()
        {
            return (this.nota1 + this.nota2) / 2;
        }
    }
}