//como descobrir qual variavel é a menor 

int x, y, z; 

String[] vet = Console.ReadLine().Split(' ');
x = int.Parse(vet[0]);
y = int.Parse(vet[1]);
z = int.Parse(vet[2]);

if(x < y && x < z){//est
    Console.WriteLine("MENOR = " + x);
} 
else{
    if (y < z){
        Console.WriteLine("MENOR = " + y);
    }
    else{
        Console.WriteLine("MENOR = " + z);
    }
}

Console.ReadLine();