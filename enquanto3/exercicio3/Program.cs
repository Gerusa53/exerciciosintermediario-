//3.Altere o exercício 5 da lista anterior (Lista de exercícios - Para) para que sejam dadas N oportunidades
//para o usuário acerte o número de bolinhas.
//Ele poderá tentar até acertar e deve ser exibido quantas tentativas foram necessárias para o acerto.

int quantidadeBolinhas = 82, chute = 0, quantidadeChutes = 0;

while(chute != quantidadeBolinhas)
{
    Console.WriteLine("Digite a quantidade de bolinhas: ");
    chute = Convert.ToInt32(Console.ReadLine());

    if (chute < quantidadeBolinhas)
    {
        Console.WriteLine(" A quantidade de bolinhas é maior. ");
    }
    if (chute > quantidadeBolinhas)
    {
        Console.WriteLine("A quantidade de bolinhas é menor. ");
    }

    quantidadeChutes++;
}
    Console.WriteLine("Você acertou, foram necessários  " + quantidadeChutes + " chutes para o acerto.");
