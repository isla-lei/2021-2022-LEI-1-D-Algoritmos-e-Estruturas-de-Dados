using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ClassPesquisaSelecao
{
    /// <summary>
    /// Método (Função) que recebe um array de inteiros e um valor a procurar dentro desse array
    /// e devolve -1 se não existir o valor ou devolve o indice do array onde está o valor
    /// </summary>
    /// <param name="vetor"></param>
    /// <param name="valorProcurar"></param>
    /// <returns></returns>
    public static int PesquisaSequencial(int[] vetor, int valorProcurar)
    {
        int n = vetor.Length;

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == valorProcurar)
            {
                return i; // retorna a posição onde encontrou o valor
            }
        }

        // não encontrou -> codigo -1
        return -1;
    } // PesquisaSequencial

    public static int PesquisaBinaria(int[] vetor, int valorProcurar)
    {

        int n = vetor.Length;

        int inf = 0;
        int sup = n - 1;
        int meio;

        while (inf <= sup)
        {

            meio = (inf + sup) / 2;
            if (vetor[meio] == valorProcurar)
            {
                return meio; // índice onde está o valor a procurar
            }
            else
            {
                if (vetor[meio] < valorProcurar)
                {
                    inf = meio + 1;
                }
                else
                {
                    sup = meio - 1;
                }
            }
        }
        // não encontrou -> codigo -1
        return -1;
    } // PesquisaBinaria


    public static int MaxSelect(int[] vetor)
    {

        int n = vetor.Length;
        if (n == 0) return -1;

        int max = vetor[0];
        for (int i = 1; i < n; i++)
        {
            if (vetor[i] > max)
            {
                max = vetor[i];
            }
        }

        return max;
    } // MaxSelect


    public static int MinSelect(int[] vetor)
    {

        int n = vetor.Length;
        if (n == 0) return -1;

        int min = vetor[0];
        for (int i = 1; i < n; i++)
        {
            if (vetor[i] < min)
            {
                min = vetor[i];
            }
        }

        return min;
    } // MinSelect


    public static void PosMaxMinSelect(int[] vetor, out int posMax, out int posMin)
    {

        int n = vetor.Length;
        if (n == 0)
        {
            posMax = -1;
            posMin = -1;
            return;
        }

        int max = vetor[0];
        int min = vetor[0];

        posMax = 0;
        posMin = 0;

        for (int i = 1; i < n; i++)
        {
            if (vetor[i] > max)
            {
                max = vetor[i];
                posMax = i;
            }

            if (vetor[i] < min)
            {
                min = vetor[i];
                posMin = i;
            }
        }

    } // PosMaxMinSelect


    public static int KMaxSelect(int[] vetor, int k)
    {

        int n = vetor.Length;
        if (k > n) return -1;

        int pos;
        int max;
        int temp;

        for (int i = 0; i < k; i++)
        {
            pos = i;
            max = vetor[pos];

            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] > max)
                {
                    max = vetor[j];
                    pos = j;
                }
            }

            if (i != pos)
            {
                temp = vetor[i];
                vetor[i] = vetor[pos];
                vetor[pos] = temp;
            }
        }

        return vetor[k - 1];
    } // KMaxSelect


    public static int KMinSelect(int[] vetor, int k)
    {

        int n = vetor.Length;
        if (k > n) return -1;

        int pos;
        int min;
        int temp;

        for (int i = 0; i < k; i++)
        {
            pos = i;
            min = vetor[pos];

            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] < min)
                {
                    min = vetor[j];
                    pos = j;
                }
            }

            if (i != pos)
            {
                temp = vetor[i];
                vetor[i] = vetor[pos];
                vetor[pos] = temp;
            }
        }

        return vetor[k - 1];
    } // KMinSelect

    public static int Contagem(int[] vetor, int valor)
    {

        int n = vetor.Length;

        int conta = 0;
        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == valor)
            {
                conta++;
            }
        }

        return conta;

    } // Contagem


} // class
