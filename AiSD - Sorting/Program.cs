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
            }
            show_table(test_table);
            selection_sort(test_table);
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
                //show_table(table);
            }
            return table;
        }

        static int[] insert_sort(int[] table)
        {
            int tmp;
            for(int i = 1; i < table.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(table[i] < table[j])
                    {
                        tmp = table[i];
                        table[i] = table[j];
                        table[j] = tmp;
                    }
                }
                //show_table(table);
            }
            return table;
        }

        static int[] selection_sort(int[] table)
        {
            int tmp_index;
            int tmp;
            for(int i = 0; i < table.Length - 1; i++)
            {
                tmp_index = i;
                tmp = table[i];
                for (int j = i + 1; j < table.Length; j++)
                {
                    if(table[j] < tmp)
                    {
                        tmp_index = j;
                        tmp = table[j];
                    }
                }
                if(tmp_index != i)
                {
                    table[tmp_index] = table[i];
                    table[i] = tmp;
                }
                show_table(table);
            }

            return table;
        }

        static void show_table(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
                Console.Write("{0} ", table[i]);
            Console.WriteLine();
        }
    }
}
