using static Sorting;
using static Infrastructure;
Console.Clear();

int [] array = CreateArray(100, 0, 100);
ShowArray(array);
Console.WriteLine();
SortSelection(array);
ShowArray(array);
