using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "fish";
            string secondWord = "finishing";

            int[][] array = DynamicProgramming.Find(firstWord, secondWord);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
