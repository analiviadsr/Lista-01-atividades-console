// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola, me fale quantos anos voce tem");
int anos = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva quantos meses voce tem");
int meses = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva quantos dias voce tem");
int dias = int.Parse(Console.ReadLine());
int ano = anos * 365;
int mes = meses * 30;
int total = ano + mes + dias;
Console.WriteLine($"Voce ja viveu { total } dias");




