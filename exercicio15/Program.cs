using System.Globalization;

int N;// declarei a variavel n 

N = int.Parse(Console.ReadLine());// solicitei que o usuario digite a qtd do valor inteiro que ira na variavel n 

string[] nomes = new string[N];//instanciação de string
int[] idades = new int[N];//instanciação de idades
double[] alturas = new double[N];// instanciação de alturas

//leitura dos dados
for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
    alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
}

//calculo da altura media das pessoas
double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma += alturas[i];
}

double media = soma / N;
Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

//porcentagem de pessoas abaixo de 16 anos
int cont = 0;
for (int i = 0; i < N; i++)
{
    if (idades[i] < 16)
    {
        cont++;
    }
}

double porcentagem = (double)cont / N * 100.0;

Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F2", CultureInfo.InvariantCulture) + "%");

Console.ReadLine();





