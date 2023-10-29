// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputSizeofArray(string message)
{
    while (true)
    {
        Console.Write(message);
        string input = Console.ReadLine();
        if (Int32.TryParse(input, out int num))
        {
            return num;
        }
        else
        {
            Console.WriteLine("Введено неверное число! Повторите ввод.");
        }
    }
}

int[] GetElementsofArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next();
    }
    return array;
}

Console.WriteLine($"[{string.Join($", ", GetElementsofArray(InputSizeofArray("Введите длину массива: ")))}]");