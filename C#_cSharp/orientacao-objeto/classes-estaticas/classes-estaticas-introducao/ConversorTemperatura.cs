namespace classes_estaticas
{
    public static class ConversorTemperatura
    {
        //propriedade estática
        public static float Temperatura { get; set; }

        //método estático
        public static float ConverterCelsiusFahrenheit(float celsius)
        {
            Temperatura = celsius;

            float fahrenheit = (Temperatura * 9 / 5) + 32;

            return fahrenheit;
        }
        public static float ConverterFahrenheitCelsius(float fahrenheit)
        {
            Temperatura = fahrenheit;

            float celsius = (Temperatura - 32) * 5 / 9;

            return celsius;
        }
    }
}