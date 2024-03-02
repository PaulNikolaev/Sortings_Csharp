public static class Sorting
{
    public static void SortSelection(int[] array)
    {
        int lenth = array.Length;
        for (int i = 0; i < lenth - 1; i++)
        {
            for (int j = 0; j < lenth - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                } 
            }
        }
    }
}