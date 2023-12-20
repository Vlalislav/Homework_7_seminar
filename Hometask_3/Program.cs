// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы





    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index]+" ");
            PrintArrayReversed(array, index - 1);
        }
    }

