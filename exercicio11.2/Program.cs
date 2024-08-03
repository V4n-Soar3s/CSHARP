int N, cont_in, cont_out;

N = int.Parse(Console.ReadLine());

cont_in = 0;
cont_out = 0;

for (int i = 0; i < N; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x >= 10 && x <= 20)
    {
        cont_in++;
    }
    else
    {
        cont_out++;
    }
}


Console.WriteLine(cont_in + " in");
Console.WriteLine(cont_out + " out");

Console.ReadLine();
