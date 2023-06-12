namespace cadastro_alunos
{
    public class Aluno
    {
        public string nome = string.Empty;
        public string curso = string.Empty;
        public int idade;
        public string rg = string.Empty;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;
        public void VerMediaFinal()
        {
            Console.WriteLine($"\nO valor da média final é: {this.mediaFinal}");
        }
        public void VerMensalidade()
        {
            float desconto = 0;
            if (bolsista == true)
            {
                if (this.mediaFinal >= 8)
                {
                    desconto = (float)50 / 100;
                }
                else if (this.mediaFinal > 6)
                {
                    desconto = (float)30 / 100;
                }
            }
            float valorDescontado = this.valorMensalidade * desconto;
            this.valorMensalidade -= valorDescontado;

            Console.WriteLine($"\nO valor da mensalidade é: {this.valorMensalidade}");
        }
    }
}