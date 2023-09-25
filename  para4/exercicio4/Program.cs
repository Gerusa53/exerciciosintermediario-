// 4.Crie um programa para ler a nota de 10 alunos de uma turma de lógica de programação.
//Apresente no final da leitura a maior nota, a menor nota e a média das notas.

using System.Net.Http.Headers;

decimal nota, maiorNota = 0, menorNota = 0, somaNotas = 0, media = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite a nota do aluno: ");
    nota = Convert.ToDecimal(Console.ReadLine());
    somaNotas += nota;

    if (i == 0)
    {
        maiorNota = nota;
        menorNota = nota;
    }
    else
    {
        if (nota > maiorNota)
        {
            maiorNota = nota;
        }
        if (nota < menorNota)
        {
            menorNota = nota;
        }

    }


    media = somaNotas / 10;
}

    Console.WriteLine("A maior nota foi : " + maiorNota);
    Console.WriteLine("A menor nota foi : " + menorNota);
    Console.WriteLine("A media das notas foi: " + media);



