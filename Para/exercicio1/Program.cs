// 1. Crie um programa que solicite 5 números e apresente na tela a soma de todos os números.

int soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número: ");
    soma += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" O resultado da soma de todos os números é: " + soma);   
