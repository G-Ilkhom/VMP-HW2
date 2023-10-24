using System;

class Project_5
{
    static void Main()
    {
        const int size = 1000;
        int[] matrix1 = new int[size * size];
        int[] matrix2 = new int[size * size];
        int[] result = new int[size * size];

        Random random = new Random();
        for (int i = 0; i < size * size; i++)
        {
            matrix1[i] = random.Next(1, 10);
            matrix2[i] = random.Next(1, 10);
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int sum = 0;
                for (int k = 0; k < size; k++)
                {
                    sum += matrix1[i * size + k] * matrix2[k * size + j];
                }
                result[i * size + j] = sum;
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(result[i * size + j] + " ");
            }
            Console.WriteLine();
        }
    }
}