int N;//declarei a variavel n 
int [] vet;//criei a variavel de vetor

N = int.Parse(Console.ReadLine());//solicitei que seja digitado um valor
vet = new int[N];// fiz a instanciação do vetor

string[] s = Console.ReadLine().Split(' ');// criei uma string para que seja possivel armazenar os valores do vetor na mesma linha
for (int i=0; i < N; i++){// criei a condição para verificar 
    vet[i] = int.Parse(s[i]);// converti o valor de string para inteiro
}

for (int i = 0; i<N ; i++){//criei uma estrutura para ler o valor dos vetores negativos que foram digitados dentro da primeira estrutura 
    if(vet[i] < 0){//se o vetor for menor que zero
        Console.WriteLine(vet[i]);//sera apresentado na tela ao final 
    }
}

Console.ReadLine();

