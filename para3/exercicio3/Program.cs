//3.Crie um programa para ler a altura de 12 atletas de basquete. Apresente no final quantos têm mais de 1.90.

int contadorMaior1_90 = 0;
decimal altura;

for (int i = 0; i < 12; i++)
{
    Console.WriteLine("Digite a altura do atleta: ");
    altura = Convert.ToDecimal(Console.ReadLine());

    if (altura > 1.90m)
    {
        contadorMaior1_90++;

    }

}

Console.WriteLine(contadorMaior1_90 + " atletas tem mais de 1.90");
