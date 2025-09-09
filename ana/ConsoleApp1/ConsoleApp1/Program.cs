// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, escreva um número");
int numero = int.Parse(Console.ReadLine());
if (numero > 10)
{
    Console.WriteLine("É maior que 10");
}
else if (numero < 10)
{
    Console.WriteLine("É menor que 10");
}
else if (numero == 10)
{
    Console.WriteLine("É igual a 10");
}

