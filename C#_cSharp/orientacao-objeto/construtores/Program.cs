using construtores;

Produto produto1 = new Produto();

produto1.Codigo = "1234";

Console.WriteLine($"{produto1.Codigo}");

Produto produto2 = new Produto("5678");

Produto produto3 = new Produto("1357", "Sampas", 50.2F);

// public Login(string email, string senha){
//     Email = email;
//     Senha = senha;
// }

// Login login = new Login(); 