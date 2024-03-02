using static Sorting;
using static Infrastructure;
Console.Clear();

int [] array = CreateArray(20, - 50, 50);
ShowArray(array);
Console.WriteLine();
SortSelection(array);
ShowArray(array);
