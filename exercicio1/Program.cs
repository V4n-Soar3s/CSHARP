using System.Globalization;

double n1, n2, notaFinal;// declarei as variaveis

n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// solicitei a primeira nota
n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// solicitei a segunda nota

notaFinal = n1 + n2; // somei ambas

Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));// mensagem de saida

if (notaFinal < 60.0){// condição simples que caso seja verdadeira sera executada
    Console.WriteLine("REPROVADO");
}

Console.ReadLine();
