//Faça um programa que leia três números, verifique (usando if e else) e mostre o maior e o menor deles;
//(Não utilize estrutura de repetição)

int numero = 0, numero1, numero2, numero3, maiorNumero = 0, menorNumero = 0;

Console.WriteLine("Digite o primeiro número? ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número? ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número? ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero3 < numero2)
{
    maiorNumero = numero1;
}
else
{
    if (numero2 > numero1 && numero2 > numero3)
    {
        maiorNumero = numero2;
    }
    if (numero3 > numero1 && numero3 > numero2)
    {
        maiorNumero = numero3;
    }
}
if (numero1 < numero2 && numero1 < numero3)
{
    menorNumero = numero1;
}
else
{
    if (numero2 < numero1 && numero2 < numero3)
    {
        menorNumero = numero2;
    }
    if (numero3 < numero1 && numero3 < numero2)
    {
        menorNumero = numero3;
    }
}


    Console.WriteLine("O maior número é: " + maiorNumero);
    Console.WriteLine("O menor número é: " + menorNumero);




