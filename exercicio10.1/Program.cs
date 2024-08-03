//estrutura for com soma e teste de número impar

int X, Y, min, max, soma;//declarei as variaveis

X = int.Parse(Console.ReadLine());//li o primeiro valor inteiro
Y = int.Parse(Console.ReadLine());// li o segundo valor inteiro


if (X < Y)//criei uma estrutura onde vai ser verificado qual o min e o maximo dos numeros declarados 
{
    min = X;
    max = Y;
}
else
{
    min = Y;
    max = X;
}

soma = 0;//fiz soma receber 0
for (int i=min+1; i<max; i++){//criei a condição onde o menor numero ira pular o primeiro e seguir contando +1
    if(i % 2 != 0){//para conferir se o numero é impar ou par usamos esse calculo
        soma += i;//se o numero for impar entrara na soma
    }
}

Console.WriteLine(soma);//sera apresentado o resultado dos intervalos existentes entre maior e menor numero impares

Console.ReadLine();