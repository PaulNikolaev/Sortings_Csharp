public static class Sorting
{
    public static void SortSelection(int[] array)
    {
        int lenth = array.Length;
        for (int i = 0; i < lenth - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < lenth; j++)
            {
                if (array[j] < array[pos])
                {
                pos = j; 
                } 
            }
            int temp = array[i];
            array[i] = array[pos];
            array[pos] = temp;
        }
    }
}