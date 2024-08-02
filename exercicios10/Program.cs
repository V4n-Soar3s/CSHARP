/*Estrutura para == for.

Fazer um programa que lê um valor inteiro N e depois N números inteiros. Ao final, mostra a soma dos N números lidos. */

int N, x, soma;// declarar as variaveis que serao utilizadas no programa 

N = int.Parse(Console.ReadLine());// ler a variavel n

soma = 0;// informar o valor inicial de soma para o compilador 
for (int i = 1; i <= N; i++)//declarar o inicio da estrutura neste caso sera iniciada com 1; informar a condição  da contagem que sera executada neste caso sera executado enquanto o valor for menor que a variavel N; e somar o valor de i mais 1 ou i++
{
    x = int.Parse(Console.ReadLine());//ler as variaveis que forem digitadas
    soma += x;//somar os valores de x e guardar na variavel soma
}

Console.WriteLine(soma);//apresentar o resultado após somar todos os valores
Console.ReadLine();//manter o programa aberto 
