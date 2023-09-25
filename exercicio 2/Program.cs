
//2.Crie um programa para ler 10 números e no final da leitura de todos os números apresente quantos números lidos foram maiores que 50.

int contadorMaior50 = 0, numero;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 50)
    {
        contadorMaior50++;
    }

}

Console.WriteLine(" foram digitados " + contadorMaior50 + " números " + " maiores que 50 ");