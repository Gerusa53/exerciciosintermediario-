//2. Crie um programa que solicite o nome, a nota 1 e a nota 2 de um aluno. Em seguida o programa deve calcular a média aritmética e,
//se o aluno ficar com nota maior ou igual a 60, o programa deve mostrar a mensagem "APROVADO". Se a nota for menor que 60
//o programa deve apresentar a mensagem "Em Recuperação".

string nome;
decimal nota1, nota2, media;

Console.WriteLine("digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("digite a nota 1: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("digite a nota 2: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if(media >= 60)
{
    Console.WriteLine(nome + " você está aprovado");

}
else
{
    Console.WriteLine(nome + " você está recuperação");
}
