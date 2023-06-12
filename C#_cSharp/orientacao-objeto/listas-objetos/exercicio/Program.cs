//Criar um projeto de console
//Criar uma classe Carro
// - Marca
// - Cor
//Criar construtor vazio e completo
//Receber dados no console para adicionar 2 objetos em uma lista
//Exibir os dois objetos da lista no console

using exercicio;

List<Carro> carros = new List<Carro>();

Console.WriteLine($"\nCadastro de carros");

//* Usando construtor completo

// for (var item = 0; item < 2; item++)
// {
//     Console.WriteLine($"Digite a marca:");
//     string marca = Console.ReadLine();
//     Console.WriteLine($"Digite a cor:");
//     string cor = Console.ReadLine();

//     carros.Add(
//         new Carro(marca, cor)
//     );
// }

// foreach (var item in carros)
// {

//     Console.WriteLine(@$"
//     Carro: {carros.IndexOf(item) + 1}

//     Marca: {item.Marca}
//     Cor: {item.Cor}");
// }

//* Usando construtor vazio

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Digite a marca:");
    carro.Marca = Console.ReadLine();
    Console.WriteLine($"Digite a cor:");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);
}

foreach (var item in carros)
{

    Console.WriteLine(@$"
    Carro: {carros.IndexOf(item) + 1}
    
    Marca: {item.Marca}
    Cor: {item.Cor}");
}


