// See https://aka.ms/new-console-template for more information

// Escreva uma função que receba como parâmetro
// o número de vitórias e o número de empates de uma equipa de futebol,
// calcule e retorne os pontos tendo em conta que:
// uma vitoria são 3 pontos e um empate é 1 ponto.


int CalculaPontos(int vitorias, int empates)
{
    int pontos;
    pontos = vitorias * 3 + empates;
    return pontos;
}

int CalculaPontos3(int vitorias, int empates)
{  
    return vitorias * 3 + empates;
}

void CalculaPontos2()
{

}

// Main
// invocar a função (método) para 5 vitorias e 3 empates 
// para ter acesso ao retorno da função, criamos uma variavel
// ou usamos o resultado diretamente (por exemplo no Console.WriteLine())

Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

int resultado =  CalculaPontos(5, 3);
Console.WriteLine($"Pontos: {resultado}");
// ou 
Console.WriteLine($"Pontos: {CalculaPontos(5,3)}");

// Pedir as vitorias e empates ao utilizador
Console.Write("Quantidade de vitorias: ");
int vit = int.Parse(Console.ReadLine());

Console.Write("Quantidade de empates: ");
int emp = int.Parse(Console.ReadLine());

resultado = CalculaPontos(vit, emp);

Console.WriteLine($"Um clube com {vit} vitórias e {emp} empates tem {resultado} pontos");