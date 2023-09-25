//
//1.Crie um programa para ler N números até que a soma dos números seja maior ou igual a 100.
//Apresente a quantidade de números necessários para alcançar a soma maior ou igual a 100.

int soma = 0, contador = 0; 

while(soma < 100)
{
    Console.WriteLine("Digite um número: ");
    soma += Convert.ToInt32(Console.ReadLine());
    contador++;
}

Console.WriteLine("foram necessários: " + contador + " números para atingir o valor de 100");


