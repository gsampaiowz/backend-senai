namespace exercicio
{
    public class Carro
    {
        //método construtor
        public Carro()
        {

        }
        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }

        //propriedades
        public string Marca { get; set; }
        public string Cor { get; set; }
    }
}