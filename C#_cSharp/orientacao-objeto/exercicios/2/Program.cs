/*2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar.

No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.

a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?

b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.

c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!
*/

using _2;

Console.Clear();
Console.WriteLine($"\nBem-vindo à Super CafeteriaTabajaras Plus++");

MaquinaCafe maquinaCafe = new MaquinaCafe();

string maisCafe;
do
{
    Console.WriteLine($"\nCafés feitos: {maquinaCafe.CafesFeitos}");

    string semAcucar = string.Empty;
    if (maquinaCafe.AcucarDisponivel > 0)
    {
        Console.WriteLine($"\nAçúcar disponível: {maquinaCafe.AcucarDisponivel}g");

        string resposta;
        do
        {
            Console.WriteLine($"\nDeseja informar a quantidade de açúcar do café? s/n");
            resposta = Console.ReadLine().ToLower();
        } while (resposta != "s" && resposta != "n");

        if (resposta == "s")
        {
            Console.WriteLine("\nDeseja quantas gramas de açúcar?");
            float acucarDesejado = float.Parse(Console.ReadLine());
            maquinaCafe.FazerCafe(acucarDesejado);
        }
        else if (resposta == "n")
        {
            maquinaCafe.FazerCafe();
        }
    }
    else if (maquinaCafe.AcucarDisponivel == 0)
    {
        Console.WriteLine($"\nInfelizmente o açúcar acabou, aceitas café sem açúcar? s/n");
        semAcucar = Console.ReadLine().ToLower();
        if (semAcucar == "s")
        {
            maquinaCafe.FazerCafe();
        }
        else if (semAcucar == "n")
        {
            Environment.Exit(0);
        }
        maquinaCafe.AcucarDisponivel--;
    }
    else
    {
        maquinaCafe.FazerCafe();
    }

    Console.WriteLine($"\nDeseja mais uma xícara de café? s/n");
    maisCafe = Console.ReadLine().ToLower();
} while (maisCafe == "s");
