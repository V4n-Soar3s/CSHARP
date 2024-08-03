//Vetores

using System.Globalization;

int N;//declarei a variavel do nº inteiro que precisa ser lido 
double[] vet;//declarei a variavel de vetor 

N = int.Parse(Console.ReadLine());// li o numero
vet = new double[N];// declarei que o vetor ira receber o tamanho do nº que for digitado em N - instanciação do vetor, nao tem como fazer a instanciação antes de ler o valor de N 

for(int i = 0; i < N ; i++){//declarei a estrutura for pra indexar os valores que vao ter as posições do vetor criado
    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

for(int i=0; i<N; i++){// esse aqui vai rodar o vetor criado e apresentar os valores dele na tela 
    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
}

Console.ReadLine();
