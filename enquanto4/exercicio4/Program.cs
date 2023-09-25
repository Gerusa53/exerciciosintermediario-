
//4.Faça um programa usando a estrutura “enquanto” que leia a idade de várias pessoas. 
//A cada laço, você deverá perguntar para o usuário se ele quer ou não continuar a digitar dados. 
//No final, quando o usuário decidir parar, mostre na tela:
//a) Quantas idades foram digitadas
//b)Qual é a média entre as idades digitadas
//c) Quantas pessoas tem 21 anos ou mais.

int idade, quantidadeMaior21 = 0, somaIdades = 0, quantidadeIdades = 0;
string continuar = "s";

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite a sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 21)
    {
        quantidadeMaior21++;
    }



    Console.WriteLine("Deseja continuar informando as idades: ");
    continuar = Console.ReadLine();

    somaIdades += idade;
    quantidadeIdades++;
}


Console.WriteLine("Quantas idades foram digitadas: " + quantidadeIdades);
Console.WriteLine("Qual média entre as idades digitadas: " + (somaIdades / quantidadeIdades));
Console.WriteLine("Quantas pessoas tem 21 anos ou mais: " + quantidadeMaior21);
    