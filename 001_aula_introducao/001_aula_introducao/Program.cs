

//int idade = 25;
//double salario = 5000.55;
//string nome = "ETEC Professor Alfredo de Barros Santos";
//char sexo = 'M';
//bool ativo = true;

//// var xyz = 22;

//Console.WriteLine("olá");
//Console.WriteLine("Mundo");

//Console.Write("olá");
//Console.Write("Mundo");

//Console.WriteLine("\n\nNome: " + nome + " Salário: " + salario);

//Console.WriteLine($"Nome: {nome} Salário: {salario}.");

//Console.WriteLine("Nome: {0} Salario: {1}", nome, salario);

//// + - / * %
//// += -= *= /= %= 
//// ++ -- 

//// Divisão
////var x = 2 / 3.0;

//Console.Clear();


//int x = 10;
//Console.WriteLine(x); //10
//Console.WriteLine(++x); // 11
//Console.WriteLine(x);



string nome;
int numero;
double salario;

Console.Write("Digite um nome: ");
nome = Console.ReadLine();
Console.WriteLine(nome);
Console.WriteLine("-------------");

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());
Console.WriteLine(numero);
Console.WriteLine("-------------");

Console.WriteLine("Digite o valor do salário: ");
salario = double.Parse(Console.ReadLine());
Console.WriteLine(salario);
Console.WriteLine("-------------");

char sexo;
Console.WriteLine("Digite M ou F");
sexo = Convert.ToChar(Console.ReadLine());
Console.WriteLine(sexo);
Console.WriteLine("-------------");

bool ativo;
Console.WriteLine("Ativo? true/false");
ativo = bool.Parse(Console.ReadLine());
Console.WriteLine(ativo);
Console.WriteLine("-------------"); 

Console.WriteLine(ativo ? "Ativo" : "Inativo" );


