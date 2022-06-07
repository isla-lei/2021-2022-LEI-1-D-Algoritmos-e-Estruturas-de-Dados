using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class ClassOrdenacao
    {
        /// <summary>
        /// BubbleSort
        /// </summary>
        /// <param name="vetor"></param>
        public static void BubbleSort(int[] vetor)
        {

            int n = vetor.Length;
            int temp;
            bool troca;

            // 1. Percorrer o vetor
            for (int i = 0; i < n - 1; i++)
            {
                // 2. Obter o valor a trocar
                troca = false;
                for (int j = i + 1; j < n; j++)
                {
                    // 3. Troca valores entre indices
                    if (vetor[i] > vetor[j])
                    {
                        temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;

                        troca = true;
                    }
                }

                // 4. Se nao houver troca termnina
                if (troca == false)
                {
                    break;
                }
            }
        }

        public static void BubbleSort_v1(int[] vetor)
        {

            int numElementos = vetor.Length;
            int temp;
            bool troca;

            // 1. Percorrer o vetor
            for (int i = numElementos - 1; i >= 0; i--)
            {
                // 2. Obter o valor a trocar
                troca = false;
                for (int j = 0; j < i; j++)
                {
                    // 3. Troca valores entre indices
                    if (vetor[j] > vetor[j + 1])
                    {
                        temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;

                        troca = true;
                    }
                }

                // 4. Se nao houver troca termnina
                if (troca == false)
                {
                    break;
                }
            }
        }


        public static void BubbleSort_v2(int[] vetor)
        {

            int n = vetor.Length;
            int temp;
            bool troca;
            int inicio = 1;

            // 1. Percorrer o vetor
            do
            {
                // 2. Obter o valor a trocar
                troca = false;
                for (int i = n - 1; i >= inicio; i--)
                {
                    // 3. Troca valores entre indices
                    if (vetor[i - 1] > vetor[i])
                    {
                        temp = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = temp;

                        troca = true;
                    }
                }

                inicio++;
            } while (troca && inicio < n);  // 4. Se nao houver troca termnina
        }


        public static void ShakerSort(int[] vetor)
        {
            int n = vetor.Length;
            bool troca = true;
            int inicio = 0;
            int fim = n - 1;
            int temp;

            while (troca)
            {
                troca = false;

                // loop da esquerda para a direita
                // como no bubble sort
                for (int i = inicio; i < fim; ++i)
                {
                    if (vetor[i] > vetor[i + 1]) // verifica se o proximo elemento é maior
                    {
                        // se o elemento da direita é maior, troca
                        temp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = temp;
                        troca = true;
                    }
                }

                // se não houve troca, vetor já está ordenado, pode terminar
                if (!troca)
                    break;

                troca = false;

                // diminui a marca do fim do vetor, 
                // porque o atual maior elemento já está no sua posição
                fim = fim - 1;


                // loop da diretia para a esquerda
                for (int i = fim - 1; i >= inicio; i--)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        temp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = temp;
                        troca = true;
                    }
                }

                // aumenta a marca do inicio do vetor, 
                // porque o atual menor elemento já está no sua posição
                inicio = inicio + 1;
            }
        }

        public static void SelectionSort(int[] vetor)
        {
            int n = vetor.Length;
            int i, j, min, temp;

            // 1. Percorre o vector de modo a inicializar o minimo
            for (i = 0; i < n - 1; i++)
            {
                min = i;

                // 2. Percorre o vector para encontrar o minimo
                for (j = i + 1; j <= n - 1; j++)
                {
                    if (vetor[j] < vetor[min])
                        min = j;
                }

                // 3. Troca de valores entre indices
                if (min != i)
                {
                    temp = vetor[i];
                    vetor[i] = vetor[min];
                    vetor[min] = temp;
                }

            }

        }

        public static void HeapSort(int[] vetor)
        {
            int n = vetor.Length;
            int i = n / 2, pai, filho, t;

            while (true)
            {
                if (i > 0)
                {
                    i--;
                    t = vetor[i];
                }
                else
                {
                    n--;
                    if (n <= 0)
                    {
                        return;
                    }
                    t = vetor[n];
                    vetor[n] = vetor[0];
                }
                pai = i;
                filho = i * 2 + 1;
                while (filho < n)
                {
                    if ((filho + 1 < n) && (vetor[filho + 1] > vetor[filho]))
                    {
                        filho++;
                    }
                    if (vetor[filho] > t)
                    {
                        vetor[pai] = vetor[filho];
                        pai = filho;
                        filho = pai * 2 + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                vetor[pai] = t;
            }
        }

        public static void InsertionSort(int[] vetor)
        {
            int n = vetor.Length;
            int i, j, temp;

            // 1. Percorrer o vector para os elementos a inserir
            for (i = 1; i < n; i++)
            {
                temp = vetor[i];
                j = i;

                // 2. Percorrer o vector ordenado para encontrar o valor inferior
                while (j > 0 && vetor[j - 1] > temp)
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }

                // 3. Insere valor na ordem
                vetor[j] = temp;
            }

        }

        public static void ShellSort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                    }
                    vetor[j] = c;
                }
                h = h / 2;
            }
        }


        public static int[] MergeSort(int[] vetor)
        {
            int[] left;
            int[] right;
            int[] result = new int[vetor.Length];

            // Como este é um algoritmo recursivo, precisamos ter um caso base para evitar uma recursão infinita e, portanto, um overflow
            if (vetor.Length <= 1)
            {
                return vetor;
            }


            // Meio do vetor  
            int midPoint = vetor.Length / 2;

            // Array da primeira parte do vetor
            left = new int[midPoint];

            // se o array tiver um número par de elementos, o array esquerdo e direito terão o mesmo número de elementos
            if (vetor.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                // se o array tiver um número ímpar de elementos, o array direito terá um elemento a mais que o esquerdo
                right = new int[midPoint + 1];
            }

            // popular array da esquerda
            for (int i = 0; i < midPoint; i++)
            {
                left[i] = vetor[i];
            }

            // popular array da direita
            int x = 0;
            // começar no índice do ponto médio 
            for (int i = midPoint; i < vetor.Length; i++)
            {
                right[x] = vetor[i];
                x++;
            }

            // ordena recursivamente o array da esquerda
            left = MergeSort(left);

            // ordena recursivamente o array da direita
            right = MergeSort(right);

            // combia os dois arrays
            
            result = Merge(left, right);

            return result;
        }

        // Este método é responsável por combinar os dois arrays
        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;

            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            // enquanto qualquer array ainda tenha elementos
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                // se ambos os arrays tenham elementos  
                if (indexLeft < left.Length && indexRight < right.Length)
                {                   
                    // Se o item no array da esquerda for menor que o item no array da direita, adicionar o item ao array de resultado
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }                    
                    // caso contrario será adicionado o item do array da direita
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }                
                // se apenas o array da esquerda tiver elementos, adicione todos os seus itens ao array de resultados
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                // se apenas o array da direita tiver elementos, adicione todos os seus itens ao array de resultados
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


        static int[] arrayAux;
        public static void MergeSort2(int[] vetor, int inicio, int fim)
        {

            // não está ma ordenar bem

            if (inicio < fim)
            {
                int meio = (fim + inicio) / 2;
                MergeSort2(vetor, inicio, meio);
                MergeSort2(vetor, meio + 1, fim);

                MergeList(vetor, inicio, meio, fim);
            }
        }
        static void MergeList(int[] vetor, int inicio, int meio, int fim)
        {
            int primeiraParte = inicio;
            int segundaParte = meio + 1;
            int i = 0;
            int tam = fim - inicio + 1;

            Array.Resize(ref arrayAux, tam);

            while (primeiraParte <= meio && segundaParte < fim)
            {
                if (vetor[primeiraParte] < vetor[segundaParte])
                {
                    arrayAux[i] = vetor[primeiraParte];
                    primeiraParte++;
                }
                else
                {
                    arrayAux[i] = vetor[segundaParte];
                    segundaParte++;
                }
                i++;
            }

            while (primeiraParte <= meio) // Caso ainda tenha elementos na 1ª parte
            {
                arrayAux[i] = vetor[primeiraParte];
                i++;
                primeiraParte++;
            }

            while (segundaParte < fim) // Caso ainda tenha elementos na 2ª parte
            {
                arrayAux[i] = vetor[segundaParte];
                i++;
                segundaParte++;
            }

            for (i = inicio; i < fim; i++) // Coloca novamente os elementos no array original 
            {
                vetor[i] = arrayAux[i - inicio];
            }
        }


        public static void QuickSort(int[] vetor, int inicio, int fim)
        {
            int e, d, temp, p;

            if (fim >= 0)
            {

                // 1. Inicializar o pivot e os índices e , d
                if (fim > inicio)
                {
                    e = inicio;
                    d = fim;
                    int meio = (int)((inicio + fim) / 2);
                    p = vetor[meio];

                    while (e <= d)
                    {
                        // 2. Percorrer o vector desde a esquerda até encontrar 
                        // um valor superior ao pivot
                        while (vetor[e] < p)
                            e = e + 1;

                        // 3. Percorrer o vector desde a direita até encontrar 
                        // um valor inferior ao pivot
                        while (p < vetor[d])
                            d = d - 1;

                        // 4. Troca de valores e actualiza indices e, d
                        if (e <= d)
                        {
                            temp = vetor[e];
                            vetor[e] = vetor[d];
                            vetor[d] = temp;
                            e = e + 1;
                            d = d - 1;
                        }
                    }

                    //5. Ordena recursivamente os subvectores restantes
                    QuickSort(vetor, inicio, d);
                    QuickSort(vetor, e, fim);

                }
            }
        }

    } // Class
}
