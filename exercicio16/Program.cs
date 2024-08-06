//Sintaxe opcional: foreach

//Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes lidos:

int N; //declarei a variavel n 

N = int.Parse(Console.ReadLine());//solicitei que o usuario digite o valor de N 
string[] vet = new string[N];//vetor

//como fazer para ler os n nomes e armazenar dentro do vetor?
for (int i = 0; i<N; i++){//criei uma condição para i < que a quantidade digitada
    vet[i] = Console.ReadLine();// que seja aceito o valor do vetor as vezes que foram adicionadas em N 
}


Console.WriteLine("Nomes lidos:");//solicitei que seja apresentada a mensagem na tela
for (int i = 0; i<N; i++){//criei uma condição para i < que a quantidade digitada
    Console.WriteLine(vet[i]);//que seja apresentada na tela 
}

Console.ReadLine();
