
//*6.Crie um programa para calcule informar se compensa mais abastecer um automóvel com gasolina ou com etanol.
//o programa solicitar ao usuário o preço da gasolina e, sem seguida, o preço do etanol. Feito isso você deve dividir o valor do etanol pelo preço da gasolina.
//Se o resultado for maior ou igual a 0.7, o programa deve apresentar a mensagem "Compensa abastecer com gasolina". Caso contrário, 
//o programa deve apresentar a mensagem "Compensa abastecer com etanol."//


decimal precoGasolina, precoAlcool, resultado;

Console.WriteLine("digite o preço da gasolina: ");
precoGasolina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("digite o preço do álcool: ");
precoAlcool = Convert.ToDecimal(Console.ReadLine());

resultado = precoAlcool / precoGasolina;

if (resultado >= 0.7m)
{
    Console.WriteLine("Compensa abastecer com gasolina");   
}
else
{
    Console.WriteLine("Compensa abastecer com álcool");  
}






