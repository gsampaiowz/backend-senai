namespace calculadora
{
    public class Calculadora
    {
        //propriedades
        public float num1;
        public float num2;
        //métodos
        public float Somar()
        {
            float result = this.num1 + this.num2;
            return result;
        }
        public float Subtrair()
        {
            float result = this.num1 - this.num2;
            return result;
        }
        public float Multiplicar()
        {
            float result = this.num1 * this.num2;
            return result;
        }
        public float Dividir()
        {
            float result = this.num1 / this.num2;
            return result;
        }
    }
}