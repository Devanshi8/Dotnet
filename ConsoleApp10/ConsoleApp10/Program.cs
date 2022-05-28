using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main2(string[] args)
        {
            int[][] jaggedarr = new int[][]
            {
                new int[]{1,2},
                new int[]{1,2,3,4,5},
                new int[]{1,2,3,4,5,6,7,8},
                new int[]{1,2,3,4,5,6,7,8,9,10}
            };
            int i, j;
            for(i=0;i<jaggedarr.Length;i++)
            {
                for(j=0;j<jaggedarr[i].Length;j++)
                {
                    Console.Write(jaggedarr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(jaggedarr[3][9]);//output =10
            
        }
    }
}
