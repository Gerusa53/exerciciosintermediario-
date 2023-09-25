//2. Faça um programa que leia três números e mostre-os em ordem decrescente.
//(Não utilize estrutura de repetição)

using System;

int numero1, numero2, numero3, aux;


Console.WriteLine("Digite o primeiro número? ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número? ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número? ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 < numero2)
{
    aux = numero1;
    numero1 = numero2;
    numero2 = aux;
}
if (numero1 < numero3)
{
    aux = numero1;
    numero1 = numero3;
    numero3 = aux;
}
if (numero2 < numero3)
{
    aux = numero2;
    numero2 = numero3;
    numero3 = aux;
}

Console.WriteLine("A ordem decrescente dos números são: " + numero1 + ", "
    + numero2 + ", " + numero3 + " ,");




