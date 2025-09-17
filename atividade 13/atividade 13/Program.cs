// See https://aka.ms/new-console-template for more information
Console.Write("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
int valor3 = int.Parse(Console.ReadLine());
int menor, meio, maior;
if (valor1 < valor2 && valor1 < valor3)
{
    menor = valor1;
}
else if (valor2 < valor1 && valor2 < valor3)
{
    menor = valor2;
}
else
{
    menor = valor3;
}
if (valor1 > valor2 && valor1 > valor3)
{
    maior = valor1;
}
else if (valor2 > valor1 && valor2 > valor3)
{
    maior = valor2;
}
else
{
    maior = valor3;
}
meio = valor1 + valor2 + valor3 - menor - maior;
Console.WriteLine("Valores em ordem crescente:");
Console.WriteLine(menor);
Console.WriteLine(meio);
Console.WriteLine(maior);



