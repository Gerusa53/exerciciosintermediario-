
//7. Crie um programa que solicite um número inteiro e apresente se ele é positivo ou negativo.


Int32 numero;

Console.WriteLine("digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("O número é positivo");
}
else
{
    Console.WriteLine("O número é negativo");
}


