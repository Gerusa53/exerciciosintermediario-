//3.Altere o exercício 2 para que seja solicitada a nota de recuperação, somente se o aluno tiver ficado em recuperação. Em seguida,
//o programa deve verificar se essa nota da recuperação é maior ou igual a 50. Se for, o programa deve mostrar a mensagem "APROVADO,
//caso contrário deve mostrar a mensagem "REPROVADO".//


string nome;
decimal nota1, nota2, media;

Console.WriteLine("digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("digite a nota 1: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("digite a nota 2: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (media >= 60)
{
    Console.WriteLine(nome + " você está aprovado");

}
else
{
    decimal notaRecuperacao;
    Console.WriteLine("digite a nota da Recuperação: ");
    notaRecuperacao =  Convert.ToDecimal(Console.ReadLine());       

    if (notaRecuperacao >= 50)
      {
        Console.WriteLine(nome + " você esta APROVADO");
      }
    else
    {
        Console.WriteLine(nome + " você está REPROVADO");
    }
}



