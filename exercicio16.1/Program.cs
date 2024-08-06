//Sintaxe foreach (significa para cada), se aplica pra coleções (vetores e outras estruturas de dados)
// quando que cabe o uso do foreach é quando precisamos percorrer todos os elementos de uma coleção 
//adendos, nós usamos o vetor de tipo string porque é um vetor de strings se fosse um vetor de outro tipo colocariamos outro tipo
//outra palavra da linguagem c# é in que significa "dentro de"

int N; //declarei a variavel n 

N = int.Parse(Console.ReadLine());//solicitei que o usuario digite o valor de N 
string[] vet = new string[N];//vetor

//como fazer para ler os n nomes e armazenar dentro do vetor?
for (int i = 0; i<N; i++){//criei uma condição para i < que a quantidade digitada
    vet[i] = Console.ReadLine();// que seja aceito o valor do vetor as vezes que foram adicionadas em N 
}


Console.WriteLine("Nomes lidos:");//solicitei que seja apresentada a mensagem na tela
foreach (string x in vet){//damos um apelido para cada elemento do vetor para que seja percorrido 
    Console.WriteLine(x);//solicitamos que seja apresentado na leitura com o apelido que criamos para ele 
}


Console.ReadLine();
