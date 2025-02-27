/*
 * ==
 * !=
 * >
 * <
 * >=
 * <=
 * 
 * &&
 * ||
 * !
 * */


int numero = 5;

string parImpar = (!(numero % 2 == 0)) ? "Par" : "Ímpar";
Console.WriteLine(parImpar);


Console.WriteLine("-----------------");

int idade = 18;
if(idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}
Console.WriteLine("-----------------");

int diaDaSemana = 1;
if (diaDaSemana == 1)
{
    Console.WriteLine("Domingo");
}
else
{
    if (diaDaSemana == 2)
    {
        Console.WriteLine("Segunda");
    }
    else
    {
        if (diaDaSemana == 3)
        {
            Console.WriteLine("Terça");
        }
        else
        {
            Console.WriteLine("Dia não encontrado");
        }
    }
}
Console.WriteLine("---------------");

diaDaSemana = 2;

if(diaDaSemana == 1)
{
    Console.WriteLine("Domingo");
}else if(diaDaSemana == 2)
{
    Console.WriteLine("Segunda");
}else if(diaDaSemana == 3)
{
    Console.WriteLine("Terça");
}
else
{
    Console.WriteLine("Dia não encontrado");
}

Console.WriteLine("---------------");

diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda");
        break;
    case 3:
        Console.WriteLine("Terça");
        break;
    case 4:
        Console.WriteLine("Quarta");
        break;
    default:
        Console.WriteLine("Dia não encontrado");
        break;
}

