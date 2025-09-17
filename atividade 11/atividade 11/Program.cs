// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, escreva o ano em que estamos:");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o ano em que nasceu:");
int nascimento = int.Parse(Console.ReadLine());
int idade = ano - nascimento;
if (idade < 16)
{
   Console.WriteLine("Você NÃO é obrigado a votar.");
}
else if (idade >= 16 && idade < 18)
{
   Console.WriteLine("Seu voto é FACULTATIVO.");
}
else // idade >= 18
 {
   Console.WriteLine("Você é OBRIGADO a votar.");
}

   

