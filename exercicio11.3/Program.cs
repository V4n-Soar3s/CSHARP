int N; 

N = int.Parse(Console.ReadLine());

for(int i = 2; i <= N ; i++){
    if(i % 2 == 0){
        int quadrado = i * i;
        Console.WriteLine(i + "^2 = " + quadrado);
    }
}

Console.ReadLine();