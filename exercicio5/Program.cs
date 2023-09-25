//5. Crie um programa para gerenciar uma fila de atendimento. O programa deve perguntar se a pessoa precisa de atendimento prioritário ou não.
//Se for respondido "sim", o programa deve mostrar a mensagem "Vá para os caixas 1, 2 e 3". Caso contrário deve mostrar a mensagem
//"Vá para qualquer caixa, exceto os 1, 2 e 3 que são prioritários".

string prioridade;

Console.WriteLine("você precisa de atendimento prioritário? ");
prioridade = Console.ReadLine();

if (prioridade == "sim")
{
    Console.WriteLine("Vá para os caixas 1, 2 e 3");
}
else
{
    Console.WriteLine("Vá para qualquer caixa, exceto os 1, 2 e 3 que são prioritários");
}
