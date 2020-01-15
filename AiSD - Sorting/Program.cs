using System;

namespace AiSD_Sorting
{
    class Program
    {
        static void Main()
        {
            double[] testTable = new double[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                testTable[i] = rand.NextDouble() * rand.Next(0, 101);
            }
            ShowTable(testTable);
            BubbleSort(testTable);
        }

        static int[] BubbleSort(int[] table)
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
                //ShowTable(table);
            }
            return table;
        }

        static int[] InsertSort(int[] table)
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
                //ShowTable(table);
            }
            return table;
        }

        static int[] SelectionSort(int[] table)
        {
            int tmpIndex;
            int tmp;
            for(int i = 0; i < table.Length - 1; i++)
            {
                tmpIndex = i;
                tmp = table[i];
                for (int j = i + 1; j < table.Length; j++)
                {
                    if(table[j] < tmp)
                    {
                        tmpIndex = j;
                        tmp = table[j];
                    }
                }
                if(tmpIndex != i)
                {
                    table[tmpIndex] = table[i];
                    table[i] = tmp;
                }
                //ShowTable(table);
            }
            return table;
        }

        static double[] BubbleSort(double[] table)
        {
            double tmp;
            bool isSorted;
            for (int i = 0; i < table.Length - 2; i++)
            {
                isSorted = true;
                for (int j = table.Length - 1; j > i; j--)
                {
                    if (table[j] < table[j - 1])
                    {
                        isSorted = false;
                        tmp = table[j - 1];
                        table[j - 1] = table[j];
                        table[j] = tmp;
                    }
                }
                //ShowTable(table);
                if (isSorted)
                {
                    break;
                }
            }
            return table;
        }

        static void ShowTable(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
                Console.Write("{0} ", table[i]);
            Console.WriteLine();
        }

        static void ShowTable(double[] table)
        {
            for (int i = 0; i < table.Length; i++)
                Console.Write("{0} ", table[i].ToString("F2"));
            Console.WriteLine();
        }
    }
}