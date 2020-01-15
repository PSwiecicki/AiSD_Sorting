using System;

namespace AiSD_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test_table = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                test_table[i] = rand.Next(0, 101);
                Console.Write("{0} ", test_table[i]);
            }
            Console.WriteLine();
            bubble_sort(test_table);
        }

        static int[] bubble_sort(int[] table)
        {
            int tmp;
            for(int i = 0; i < table.Length - 2; i++)
            {
                for(int j = table.Length - 1; j > i; j--)
                {
                    if (table[j] < table[j - 1])
                    {
                        tmp = table[j - 1];
                        table[j - 1] = table[j];
                        table[j] = tmp;
                    }
                }
                /*
                for(int j = 0; j <10; j++)
                    Console.Write("{0} ", table[j]);
                Console.WriteLine();
                */
            }
            return table;
        }
    }
}
