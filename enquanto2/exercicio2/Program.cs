//2.Crie um programa para ler o nome e a velocidade da volta de N pilotos em uma pista de kart.
//Ao final do programa, você deve apresentar o nome do piloto com a volta mais rápida, o nome do
//piloto com a volta mais lenta e a média das voltas de todos os pilotos.
//A cada inserção de tempo, pergunte ao usuário se quer continuar informando.

string continuar = "s", nomePiloto = "", nomePilotoMaisRapido = "", nomePilotoMaisLento = "";
decimal tempoVolta, tempoVoltaMaisRapido = 0, tempoVoltaMaisLento = 0, totalTempo = 0;
int quantidadePilotos = 0;

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite o nome do piloto: ");
    nomePiloto = Console.ReadLine();
    Console.WriteLine("Digite o tempo da volta do piloto: ");
    tempoVolta = Convert.ToDecimal(Console.ReadLine());

    if(quantidadePilotos == 0)
    {
        tempoVoltaMaisRapido = tempoVolta;
        tempoVoltaMaisLento = tempoVolta;
        nomePilotoMaisRapido = nomePiloto;  
        nomePilotoMaisLento = nomePiloto;   
    }
    else
    {
        if(tempoVoltaMaisRapido > tempoVolta)
        {
            tempoVoltaMaisRapido = tempoVolta;
            nomePilotoMaisLento = nomePiloto;   
         }
        if(tempoVoltaMaisLento < tempoVolta)
        {
            tempoVoltaMaisLento = tempoVolta;
            nomePilotoMaisLento = nomePiloto;
        }
        
    }
        quantidadePilotos++;
        totalTempo += tempoVolta;

    Console.WriteLine("Deseja continuar informando tempo e  pilotos: ");
    continuar = Console.ReadLine();


}
Console.WriteLine("O nome do piloto mais rapido é: " + nomePilotoMaisRapido + " com o tempo de " + tempoVoltaMaisRapido);
Console.WriteLine("O nome do piloto mais lento é: " + nomePilotoMaisLento + " com o tempo de " + tempoVoltaMaisLento);
Console.WriteLine("A média de tempo entre as voltas é de: " + (totalTempo / quantidadePilotos));





