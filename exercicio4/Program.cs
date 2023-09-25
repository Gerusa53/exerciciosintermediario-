//4. Crie um programa para uma loja de sucos. O preço de cada suco é R$ 5.50, porém, se o cliente comprar mais que 10 sucos,
//o preço individual passa para R$ 4.50. O programa deve solicitar a quantidade de sucos desejados pelo cliente e apresentar o preço final a ser pago.;

Int32 quantidadeSucos;
decimal ValorSuco;

Console.WriteLine("digite a quantidade de sucos: ");
quantidadeSucos = Convert.ToInt32(Console.ReadLine());

if(quantidadeSucos > 10)
{
    ValorSuco = 4.50m;
}
else
{
    ValorSuco = 5.50m;
}

Console.WriteLine(" o valor total da sua compra foi de: " + ( quantidadeSucos * ValorSuco ) );
