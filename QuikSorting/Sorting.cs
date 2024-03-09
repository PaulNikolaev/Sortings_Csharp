public static class Sorting
{
    public static int[] Concat(int[] a, int[] b, int[] c)
    {
        int[] result = new int[a.Length + b.Length + c.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i];
        }
        for (int i = a.Length; i < a.Length + b.Length; i++)
        {
            result[i] = b[i - a.Length];
        }    
        for (int i = a.Length + b.Length; i < result.Length; i++)
        {
            result[i] = c[i - (a.Length + b.Length)];
        }
        return result;
    }

    public static int[] QuickSort(int[] array){
        if (array.Length < 2)
        {
            return array;
        }
        else
        {
            int pivot = array[0];
            int count = 0;
            foreach(int element in array)
            {
                if (element < pivot)
                    count++;
            }
            int[] less = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    less[j] = array[i];
                    j++;
                }
            }
            count = 0;
            foreach(int element in array)
            {
                if (element > pivot)
                    count++;
            }
            int[] greater = new int[count];
            j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > pivot)
                {
                    greater[j] = array[i];
                    j++;
                }
            }
            count = 0;
            foreach(int element in array)
            {
                if (element == pivot)
                    count++;
            }
            int[] pivotArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                pivotArray[i] = pivot;
            }
            int[] result = Concat(QuickSort(less), pivotArray, QuickSort(greater));
            return result;
        }
    }
}

