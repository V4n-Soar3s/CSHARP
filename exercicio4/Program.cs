//Consumo de franquia (Operadores de atribuição cumulativa)

using System.Globalization;
 
 int minutos;
 double conta;

 conta = 50.0;

 minutos = int.Parse(Console.ReadLine());


 if (minutos > 100){
    conta += (minutos - 100) * 2.0;//atribuicao cumulativa
 }

Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();

