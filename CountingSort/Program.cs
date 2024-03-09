﻿//сортировка подсчетом
using static Sorting;
using static Infrastructure;
Console.Clear();

int [] array = CreateArray(15);
ShowArray(array);
Console.WriteLine();
int [] arraySort = CountingSortExtended(array);
ShowArray(arraySort);


