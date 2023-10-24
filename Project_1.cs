using System;

class Project_1
{
    static void Main()
    {
        int N, M;
        do
        {
            Console.Write("Введите количество элементов в массиве N: ");
            N = Convert.ToInt32(Console.ReadLine());
        } while (N <= 0);

        do
        {
            Console.Write("Введите количество элементов в массиве M: ");
            M = Convert.ToInt32(Console.ReadLine());
        } while (M <= 0);

        Random rand = new Random();
        int[] arrayN = new int[N];
        for (int i = 0; i < N; i++)
            arrayN[i] = rand.Next(0, 100);

        Console.Write("Массив N: ");
        foreach (int index in arrayN)
            Console.Write(index + " ");

        int[] arrayM = new int[M];
        for (int i = 0; i < M; i++)
        {
            arrayM[i] = rand.Next(0, 100);
        }

        Console.Write("\nМассив M: ");
        foreach (int index in arrayM)
            Console.Write(index + " ");

        int K;
        do
        {
            Console.Write($"\nВведите позицию, с которой начинается вставка(1 <= K <= {N}): ");
            K = Convert.ToInt32(Console.ReadLine());
        } while (K < 1 || K > N);

        Array.Resize(ref arrayN, N + M);

        for (int index = arrayN.Length - 1; index > arrayN.Length - 1 - (N - K + 1); index--)
            arrayN[index] = arrayN[index - M];

        for (int index = K - 1; index < K - 1 + M; index++)
            arrayN[index] = arrayM[index - K + 1];

        Console.Write("Итоговый массив: ");
        foreach (int value in arrayN)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}