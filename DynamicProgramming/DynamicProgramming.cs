namespace DynamicProgramming
{
    public static class DynamicProgramming
    {
        public static int[][] Find(string word, string comparedWord)
        {
            var mainWordLength = word.Length;
            var comparedWordLength = comparedWord.Length;
            int[][] matrixArray = new int[mainWordLength][];

            for (int i = 0; i < mainWordLength; i++)
            {
                matrixArray[i] = new int[comparedWord.Length];

                for (int j = 0; j < comparedWordLength; j++)
                {
                    if (word[i] == comparedWord[j] && (i == 0 || j == 0))
                    {
                        matrixArray[i][j] = 1;
                    }
                    else if (word[i] == comparedWord[j])
                    {
                        matrixArray[i][j] = matrixArray[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        matrixArray[i][j] = 0;
                    }
                }
            }

            return matrixArray;
        }
    }
}
