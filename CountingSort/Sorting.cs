public static class Sorting
{
    public static void CountingSort(int[] inputArray)
    {
        int[] counters = new int[10]; //массив повторений

        for (int i = 0; i < inputArray.Length; i++)
        {
            counters[inputArray[i]]++;
            // ourNumber = inputArray[i];
            // counters[ourNumber]++;
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                inputArray[index] = i;
                index++;
            }
        }
    }


    public static int[] CountingSortExtended(int[] inputArray)
    {
        int max = inputArray.Max();
        int min = inputArray.Min();

        int offset = -min;
        int[] sortedArray = new int[inputArray.Length];
        int[] counters = new int[max + offset + 1];



        for (int i = 0; i < inputArray.Length; i++)
        {
            counters[inputArray[i] + offset]++;
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                sortedArray[index] = i - offset;
                index++;
            }
        }

        return sortedArray;
    }
}

