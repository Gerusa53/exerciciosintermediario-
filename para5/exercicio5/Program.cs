//5.Crie um programa que solicite ao usuário o número de bolinhas de gude que estão em um pote de vidro.
//Se o número digitado for igual a 82, apresente a mensagem "Parabéns, você acertou".
//se o número digitado for menor que 82, apresente a mensagem: "Você errou! Existem mais bolinhas do que você digitou"
//Se o número digitado for maior que 82, apresente a mensagem "Você errou! Existem menos bolinhas do que você digitou."
//O programa deve dar 5 oportunidades para que o usuário tente acertar a quantidade correta de bolinhas.

int Bolinhas = 82, chute = 0;

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("chute a quantidade de bolinhas: ");
    chute = Convert.ToInt32(Console.ReadLine());   

    if(chute == Bolinhas )
    {
        Console.WriteLine("Parabéns, você acertou ");
        break;
    }
    else if(chute < Bolinhas)
    {
        Console.WriteLine("Você errou! Existem mais bolinhas do que você digitou");
    }
    else
    {
        Console.WriteLine("Existem menos bolinhas do que você digitou.");
    }
}