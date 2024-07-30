//Função Enquanto (While)

int x, soma;//declarei duas variaveis x e soma

x = int.Parse(Console.ReadLine());// solicitei que o usuario digite um valor

soma = 0;//informei que a variavel soma inicialmente vale 0
while ( x != 0){//enquanto x for diferente de 0 faça
    soma += x;//soma vai receber 0 + o valor digitado no x e toda vez que o while der verdadeiro e entrar nessa estrutura sera somado o que ja havia nela + o novo valor
    x = int.Parse(Console.ReadLine());// vai repetir o comando enquanto a condição for verdadeira
}

Console.WriteLine(soma);//ira aparecer o total de valores verdadeiros que foramn digitados após a condição finalizar o bloco de comando

Console.ReadLine();