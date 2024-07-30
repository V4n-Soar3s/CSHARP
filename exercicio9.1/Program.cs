/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

Entrada
A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.

Saída
Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.*/

string[] valores = Console.ReadLine().Split(' ');
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("quarto");
    }
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
}