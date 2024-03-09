
int[] Concat(int[] a, int[] b, int[] c){
    int[] result = new int[a.Length + b.Length + c.Length];
    for (int i = 0; i < a.Length; i++){
        result[i] = a[i];
    }
    for (int i = a.Length; i < a.Length + b.Length; i++){
        result[i] = b[i - a.Length];
    }    
    for (int i = a.Length + b.Length; i < result.Length; i++){
        result[i] = c[i - (a.Length + b.Length)];
    }
    return result;
}

int[] quickSort(int[] array){
    if (array.Length < 2){
        return array;
    }
    else{
        int pivot = array[0];
        int count = 0;
        foreach(int element in array){
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < pivot){
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > pivot){
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach(int element in array){
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++){
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}


Console.Clear();
int[] array = {7, 4, 1, 3, 5, 2, 8, 6};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсростированный массив: [{string.Join(", ", quickSort(array))}]");