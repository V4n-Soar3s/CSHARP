using System.Globalization;
using System.Runtime.InteropServices;

int N;//declarei a variavel n que ira ler a quantidade de vezes que o programa ira aceitar os valores
double[] A;//declarei a variavel de vetor

N = int.Parse(Console.ReadLine());// solicitei que o usuario digita a quantia 
A = new double[N];// aqui é a instanciação 

string[] s = Console.ReadLine().Split(' ');// criei o split para conseguir digitar os valores na mesma linha
for (int i = 0; i<N; i++){
    A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);// tranformei em double a string
}

for (int i = 0; i<N; i++){
    Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");// solicitei pra exibir os valores
}

Console.WriteLine();

double soma = 0.0;//declarei a variavel de soma recebendo o valor de 0
for (int i=0; i<N; i++){
    soma += A[i];// solicitei que ela some o primeiro indice
}

double media = soma / N;// declarei a variavel de media 

Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture)); // solcitei que seja exibida a soma
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));// solicitei que seja exibida a media 

Console.ReadLine();