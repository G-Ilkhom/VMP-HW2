using System;

class Project_2
    {
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Введите количество элементов в массиве N: ");
            N = Convert.ToInt32(Console.ReadLine());
        } while (N <= 0);

        Random random = new Random();
        int[] arrayN = new int[N];
        for (int i = 0; i < N; i++)
        {
            arrayN[i] = random.Next(0, 100);
        }

        Console.WriteLine("Исходный массив: ");
        foreach (int index in arrayN)
            Console.Write(index + " ");

        for (int index = 0; index < N / 2; index++)
        {
            int item = arrayN[index];
            if(N % 2 == 0)
            {
                arrayN[index] = arrayN[index + N / 2];
                arrayN[index + N / 2] = item;
            }
            else
            {
                arrayN[index] = arrayN[index + 1 + N / 2];
                arrayN[index + 1 + N / 2] = item;
            }
        }

        Console.WriteLine("\nМассив после замены: ");
        foreach (int value in arrayN)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}