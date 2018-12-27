namespace QuickSort
{
    public static class QuickSort
    {
        public static void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);

                if (pivot > 1)
                    Sort(array, start, pivot - 1);

                if (pivot + 1 < end)
                    Sort(array, pivot + 1, end);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            var prior = array[left];

            while (true)
            {
                while (array[left] < prior)
                    left++;

                while (array[right] > prior)
                    right--;

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
