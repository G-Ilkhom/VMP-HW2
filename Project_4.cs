using System;

class Project_4
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Введите количество рядов(n > 0): ");
            n = Convert.ToInt32(Console.ReadLine());
        } while(n <= 0);

        int m;
        do
        {
            Console.Write("Введите количество мест в каждом ряду(m > 0): ");
            m = Convert.ToInt32(Console.ReadLine());
        } while (m <= 0);

        int[,] cinema = new int[n, m];

        Console.WriteLine("Введите информацию о проданных билетах(0 - свободно, 1 - продано): ");
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                cinema[i, j] = Convert.ToInt32(row[j]);
            }
        }

        int k;
        do
        {
            Console.Write("Введите количество требуемых билетов(k > 0): ");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k <= 0);

        bool found = false;
        int row_number = 0;
        int free_place = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (cinema[i, j] == 0)
                {
                    free_place++;
                    if (free_place == k)
                    {
                        found = true;
                        row_number = i + 1;
                        break;
                    }
                }
                else
                {
                    free_place = 0;
                }
            }
            if (found)
            {
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"Ряд: {row_number}");
        }
        else
        {
            Console.WriteLine("Подходящего ряда нет");
        }
    }
}