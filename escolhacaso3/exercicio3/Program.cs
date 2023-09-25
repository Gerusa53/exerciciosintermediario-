//3.Crie um programa que solicite o tamanho de uma blusa (P, M e G) e apresente o tamanho da blusa solicitada 
//P: 0.46 x 0.55
//M: 0.51 x 0.56
//G: 0.52 x 0.58



Console.WriteLine("Digite o tamanho da blusa: (P,M, G)");
string tamanho = Console.ReadLine();

switch(tamanho.ToUpper())
{
    case "P":
        Console.WriteLine("P: 0.46 x 0.55");
        break;
    case "M":
        Console.WriteLine("M: 0.51 x 0.56");
        break;
        case "G":
        Console.WriteLine("G: 0.52 x 0.58");
        break;
        default:
        Console.WriteLine("código inválido");
        break;
}


