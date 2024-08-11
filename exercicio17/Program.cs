/*
Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). Mostrar tambpem a posição do maior elemento.
*/

using System.Globalization;

int N;// declarei a variavel n 

N = int.Parse(Console.ReadLine());//solicitei que o usuario de um valor para ela
double [] numReal = new double[N];//informei que esse valor sera associado a numeros doubles 

for (int i = 0; i< N; i++){//para numeros menor que a quantia digitada em N deixar o usuario digitar 
    numReal [i] =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double maior = numReal[0];//criei a variavel maior
int posicao = 0;// criei a variavel posicao 

for (int i = 1; i< N; i++){//condicao para
    if(numReal[i] > maior)// o numero maior sera apresentado seu indice
    {
        maior = numReal[i];//declarei que o maior numero deve se tornarl o indicie 1 
        posicao = i;// na posicao 1
    }
}

Console.WriteLine($"O maior número é: {maior}");//solicitei que seja apresentada na tela o maior numero
Console.WriteLine($"A posição do maior número é: {posicao}");//solicitei que seja apresentado conforme seu indice

Console.ReadLine();