namespace _2
{
    public class MaquinaCafe
    {
        public float AcucarDisponivel { get; set; } = 500;
        public int CafesFeitos { get; set; } = 0;

        public void FazerCafe(float _acucarDesejado)
        {
            Console.Clear();

            if (AcucarDisponivel >= _acucarDesejado)
            {
                Console.WriteLine($"\nAqui está seu café com {_acucarDesejado}g de açúcar.");
                AcucarDisponivel -= _acucarDesejado;
            }
            else
            {
                Console.WriteLine("\nAçúcar insuficiente na máquina!");
            }
            CafesFeitos++;
        }
        public void FazerCafe()
        {
            Console.Clear();

            if (AcucarDisponivel >= 10)
            {
                Console.WriteLine($"\nAqui está seu café com 10g de açúcar.");
                AcucarDisponivel -= 10;
            }
            else
            {
                Console.WriteLine($"\nAqui está seu café sem açúcar.");
            }
            CafesFeitos++;
        }
    }
}