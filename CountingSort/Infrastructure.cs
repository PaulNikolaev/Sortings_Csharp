public static class Infrastructure
{
    public static int [] CreateArray(int lengh, int min = 0, int max = 9)
    {
        int [] array = new int[lengh];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max + 1); 
        }
        return array;
    }

    public static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} \t"); 
        } 
    }
}