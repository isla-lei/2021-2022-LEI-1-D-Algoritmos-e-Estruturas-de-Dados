// See https://aka.ms/new-console-template for more information


// Elabore um programa em C# para ler uma matriz matrizNum[5,5] de números inteiros

// definir a matrizNum[5,5]
int[,] matrizNum = new int[5, 5];


// main
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

PreencheMatriz(matrizNum);
MostraMatriz(matrizNum);

Console.Clear();
MostraMatriz(matrizNum);
SomaMatriz(matrizNum);

MostraMatriz(matrizNum);
SomaLinha3(matrizNum);

//Console.Write("Linha a somar: ");
//int linha = int.Parse(Console.ReadLine());
//SomaLinha(matrizNum, linha);

MostraMatriz(matrizNum);
Cabecalho("c) a soma dos elementos de uma coluna (perguntar ao utilizador)");
Console.Write("Coluna a somar (0 a 4): ");
int coluna = int.Parse(Console.ReadLine());
SomaColuna(matrizNum, coluna);

MostraMatriz(matrizNum);
Cabecalho("d) a quantidade de elementos da matriz iguais a um valor (perguntar ao utilizador)");
Console.Write("Valor a procurar: ");
int numero = int.Parse(Console.ReadLine());
ContaElementos(matrizNum, numero);


MostraMatriz(matrizNum);
MaxLinha(matrizNum);

MostraMatriz(matrizNum);
MediaLinha(matrizNum);

MostraMatriz(matrizNum);
MediaColuna(matrizNum);

MostraMatriz(matrizNum);
SomaDiagonalPrincipal(matrizNum);

MostraMatriz(matrizNum);
SomaDiagonalSecundaria(matrizNum);

//

void Cabecalho(string Texto)
{
    Console.WriteLine("*****************************************************************************************");
    Console.WriteLine(Texto);

}

void PreencheMatriz(int[,] matriz)
{

    Random aletorio = new Random();
    int valor;

    // Ler os valores para a matriz

    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        for (int c = 0; c < 5; c++) // c varia de 0 a 4
        {
            //Console.Write("Valor para linha " + l + " Coluna " + c + ": ");

            // preenchimento manual da matriz (pedir ao utilizador)
            // Console.Write($"Valor para linha {l} Coluna {c}: ");
            // matriz[l, c] = int.Parse(Console.ReadLine());

            // preenchimento automático
            Console.Write($"Valor para linha {l} Coluna {c}: ");
            valor = aletorio.Next(1, 1001); // valores aleatorio entre 1 e 1000
            Console.WriteLine(valor);
            matriz[l, c] = valor;
        }

        // mudar de linha (l)
        Console.WriteLine();
    }

    Console.WriteLine("Matriz Preenchida...");
    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();

}// PreencheMatriz

void MostraMatriz(int[,] matriz)
{

    Console.WriteLine("VALORES DA MATRIZ");
    Console.WriteLine("-------------------------------------");

    // Mostrar a Matriz
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        for (int c = 0; c < 5; c++) // c varia de 0 a 4
        {
            Console.Write(matriz[l, c].ToString().PadRight(8)); // PadRight -> 8 caracteres, conpleta com espaços em branco
        }

        // mudar de linha (l)
        // Console.WriteLine();
        Console.WriteLine();
    }

    //Console.WriteLine("ENTER p/ continuar...");
    //Console.ReadKey();
}// MostraMatriz


void SomaMatriz(int[,] matriz)
{
    //
    // a) soma dos elementos de toda a matriz
    //
    Cabecalho("a) soma dos elementos de toda a matriz");

    int soma = 0;
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        for (int c = 0; c < 5; c++) // c varia de 0 a 4
        {
            soma += matriz[l, c]; // soma = soma + matrizNum[l, c];
        }
    }

    Console.WriteLine($"Soma de todos os elementos da matrizNum: {soma}");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();

}

void SomaLinha3(int[,] matriz)
{
    //
    // b) a soma dos elementos da linha 3
    //
    Cabecalho("b) a soma dos elementos da linha 3");

    int soma = 0;
    soma = 0;
    for (int c = 0; c < 5; c++) // c varia de 0 a 4
    {
        Console.Write(matriz[3, c].ToString().PadRight(8));
        soma += matriz[3, c]; // soma = soma + matrizNum[3, c];
    }
    Console.WriteLine();
    Console.WriteLine($"Soma da linha 3 da matrizNum: {soma}");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}

void SomaLinha(int[,] matriz, int linha)
{
    //
    // b) a soma dos elementos de uma linha
    //
    Cabecalho("b) a soma dos elementos de uma linha");

    int soma = 0;
    soma = 0;
    for (int c = 0; c < 5; c++) // c varia de 0 a 4
    {
        Console.Write(matriz[linha, c].ToString().PadRight(8));
        soma += matriz[linha, c]; // soma = soma + matriz[linha, c];
    }
    Console.WriteLine();
    Console.WriteLine($"Soma da linha {linha} da matrizNum: {soma}");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}

void SomaColuna(int[,] matriz, int coluna)
{
    //
    // c) a soma dos elementos de uma coluna (perguntar ao utilizador)
    //

    int soma = 0;
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        Console.WriteLine(matriz[l, coluna]);
        soma += matriz[l, coluna]; // soma = soma + matriz[l, coluna];
    }
    Console.WriteLine();
    Console.WriteLine($"Soma da coluna {coluna} da matrizNum: {soma}");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}

void ContaElementos(int[,] matriz, int valor)
{
    //
    // d) a quantidade de elementos da matriz iguais a um valor (perguntar ao utilizador)
    //

    int conta = 0;
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        for (int c = 0; c < 5; c++) // c varia de 0 a 4
        {
            if (matrizNum[l, c] == numero)
            {
                conta += 1; //  conta = conta + 1;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Quantidade numeros iguais a {numero}: {conta} ");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();

}


void MaxLinha(int[,] matriz)
{
    //
    // e) o maior elemento de cada linha da matriz
    //
    Cabecalho("e) o maior elemento de cada linha da matriz");

    int max;
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        // inicio de nova linha
        max = matriz[l, 0]; // assumir que o máximo é o 1º da linha

        for (int c = 1; c < 5; c++) // c varia de 0 a 4
        {
            // inicio de nova coluna
            if (matriz[l, c] > max)
            {
                max = matriz[l, c];
            }
        }

        // fim de uma linha
        Console.WriteLine($"Máximo da linha {l}: {max}");

    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}

void MediaLinha(int[,] matriz)
{
    //
    // f) a média dos elementos de cada LINHA    
    //
    Cabecalho("f) a média dos elementos de cada LINHA ");
    int soma = 0;
    double media;
    for (int l = 0; l < 5; l++) // l varia de 0 a 4
    {
        // inicio de nova linha              
        soma = 0;
        for (int c = 0; c < 5; c++) // c varia de 0 a 4
        {
            // inicio de nova coluna
            soma += matrizNum[l, c];
        }

        // fim de uma linha
        media = soma / 5;
        Console.WriteLine($"Média da linha {l}: {media}");

    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();

}

void MediaColuna(int[,] matriz)
{
    //
    // g) a média dos elementos de cada COLUNA    
    //
    Cabecalho("g) a média dos elementos de cada COLUNA");
    int soma = 0;
    double media;
    for (int c = 0; c < 5; c++) // c varia de 0 a 4
    {
        // inicio de nova linha              
        soma = 0;
        for (int l = 0; l < 5; l++) // l varia de 0 a 4
        {
            // inicio de nova coluna
            soma += matrizNum[l, c];
        }

        // fim de uma linha
        media = soma / 5;
        Console.WriteLine($"Média da Coluna {c}: {media}");

    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}


void SomaDiagonalPrincipal(int[,] matriz)
{
    //
    // h) a soma dos elementos da diagonal principal
    //
    Cabecalho("h) a soma dos elementos da diagonal principal");
    int soma = 0;
    for (int i = 0; i < 5; i++)
    {
        soma += matrizNum[i, i];
    }

    Console.WriteLine();
    Console.WriteLine($"Soma da diagonal principal: {soma} ");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("ENTER p/ continuar...");
    Console.ReadKey();
}

void SomaDiagonalSecundaria(int[,] matriz)
{
    // 
    // i) a soma dos elementos da diagonal secundária
    //
    Cabecalho("i) a soma dos elementos da diagonal secundária");

    int soma = 0;
    int col;
    for (int lin = 0; lin < 5; lin++)
    {
        col = 4 - lin;
        soma += matrizNum[lin, col];
    }
    Console.WriteLine();
    Console.WriteLine($"Soma da diagonal secundária: {soma} ");
    Console.WriteLine();
    Console.WriteLine();

    // Pausa
    Console.WriteLine("ENTER p/ terminar...");
    Console.ReadKey();
}