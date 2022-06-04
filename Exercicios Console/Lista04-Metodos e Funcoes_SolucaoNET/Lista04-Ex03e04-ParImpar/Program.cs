// See https://aka.ms/new-console-template for more information
//
// 3.Escreva uma FUNÇÃO que receba um número e
// retorne -1 se o número for ímpar ou 1 se for par.
int VerificaParImpar(int numero)
{
    if (numero % 2 == 0)
    {
        return 1;
    }
    else
    {
        return -1;
    }
}

// 4. Escreva um PROCEDIMENTO que receba um número e
// escreve se o número é ímpar ou se é par.
void EscreveParImpar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("PAR");
    }
    else
    {
        Console.WriteLine("IMPAR"); 
    }
}

// Main
// invocar a função (método) para o numero 10 e 5 
// para ter acesso ao retorno da função, criamos uma variavel
// ou usamos o resultado diretamente (por exemplo no Console.WriteLine())

Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("FUNÇÃO, Numero 10 e 5");
int resultado = VerificaParImpar(10);
Console.WriteLine($"Resultado: {resultado}");
resultado = VerificaParImpar(5);
Console.WriteLine($"Resultado: {resultado}");

// Procedimento
Console.WriteLine();
Console.WriteLine("PROCEDIMENTO, Numero 10 e 5");
EscreveParImpar(10);
EscreveParImpar(5);

// Pedir o numero ao utilizador
Console.Write("Numero para analisar: ");
int num = int.Parse(Console.ReadLine());
resultado = VerificaParImpar(num);
Console.WriteLine($"Resultado: {resultado}");

