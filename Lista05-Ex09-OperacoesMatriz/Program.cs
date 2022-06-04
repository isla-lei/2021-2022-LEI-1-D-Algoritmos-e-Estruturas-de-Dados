using System;

namespace Lista05_EX09_OperacoesMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            // Elabore um programa em C# para ler uma matriz matrizNum[5,5] de números inteiros

            // definir a matrizNum[5,5]
            int[,] matrizNum = new int[5, 5];

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
                    // matrizNum[l, c] = int.Parse(Console.ReadLine());

                    // preenchimento automático
                    Console.Write($"Valor para linha {l} Coluna {c}: ");
                    valor = aletorio.Next(1, 1001); // valores aleatorio entre 1 e 1000
                    Console.WriteLine(valor);
                    matrizNum[l, c] = valor;
                }

                // mudar de linha (l)
                Console.WriteLine();
            }


            // Mostrar a Matriz
            for (int l = 0; l < 5; l++) // l varia de 0 a 4
            {
                for (int c = 0; c < 5; c++) // c varia de 0 a 4
                {
                    Console.Write(matrizNum[l, c].ToString().PadRight(8)); // PadRight -> 8 caracteres, conpleta com espaços em branco
                }

                // mudar de linha (l)
                Console.WriteLine();
                Console.WriteLine();
            }

            //
            // a) soma dos elementos de toda a matriz
            //
            int soma = 0;
            for (int l = 0; l < 5; l++) // l varia de 0 a 4
            {
                for (int c = 0; c < 5; c++) // c varia de 0 a 4
                {
                    soma += matrizNum[l, c]; // soma = soma + matrizNum[l, c];
                }
            }

            Console.WriteLine($"Soma de todos os elementos da matrizNum: {soma}");
            Console.WriteLine();
            Console.WriteLine();

            //
            // b) a soma dos elementos da linha 3
            //
            soma = 0;
            for (int c = 0; c < 5; c++) // c varia de 0 a 4
            {
                Console.Write(matrizNum[3, c].ToString().PadRight(8));
                soma += matrizNum[3, c]; // soma = soma + matrizNum[3, c];
            }
            Console.WriteLine();
            Console.WriteLine($"Soma da linha 3 da matrizNum: {soma}");
            Console.WriteLine();
            Console.WriteLine();


            //
            // c) a soma dos elementos de uma coluna (perguntar ao utilizador)
            //
            soma = 0;
            Console.Write("Número da coluna para somar (0...4): ");
            int coluna = int.Parse(Console.ReadLine());
            for (int l = 0; l < 5; l++) // l varia de 0 a 4
            {
                Console.WriteLine(matrizNum[l, coluna]);
                soma += matrizNum[l, coluna]; // soma = soma + matrizNum[l, coluna];
            }
            Console.WriteLine();
            Console.WriteLine($"Soma da coluna {coluna} da matrizNum: {soma}");
            Console.WriteLine();
            Console.WriteLine();


            //
            // d) a quantidade de elementos da matriz iguais a um valor (perguntar ao utilizador)
            //
            Console.Write("Valor a procurar: ");
            int numero = int.Parse(Console.ReadLine());
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


            //
            // e) o maior elemento de cada linha da matriz
            //
            int max;
            for (int l = 0; l < 5; l++) // l varia de 0 a 4
            {
                // inicio de nova linha
                max = matrizNum[l, 0]; // assumir que o máximo é o 1º da linha

                for (int c = 1; c < 5; c++) // c varia de 0 a 4
                {
                    // inicio de nova coluna
                    if (matrizNum[l, c] > max)
                    {
                        max = matrizNum[l, c];
                    }
                }

                // fim de uma linha
                Console.WriteLine($"Máximo da linha {l}: {max}");

            }
            Console.WriteLine();
            Console.WriteLine();
            
            //
            // f) a média dos elementos de cada LINHA    
            //
            soma = 0;
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

            //
            // g) a média dos elementos de cada COLUNA    
            //
            soma = 0;
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

            //
            // h) a soma dos elementos da diagonal principal
            //
            soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma += matrizNum[i, i];
            }

            Console.WriteLine();
            Console.WriteLine($"Soma da diagonal principal: {soma} ");
            Console.WriteLine();
            Console.WriteLine();

            // 
            // i) a soma dos elementos da diagonal secundária
            //
            soma = 0;
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
    }
}
