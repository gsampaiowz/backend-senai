namespace conversor_moedas
{
    public static class ConversorMoedas
    {
        //atributos estáticos
        public static float Dolar { get; set; } = 4.99F;
        public static float Euro { get; set; } = 0.18F;
        //métodos estáticos
        public static float ConverterRealDolar(float real)
        {
            float valor = real / Dolar;

            return valor;
        }
        public static float ConverterRealEuro(float real)
        {
            float valor = real * Euro;

            return valor;
        }
    }
}