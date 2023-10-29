// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string message)
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


int GetSumNumbers(int number)
{
    number = Math.Abs(number);
    int summ = 0;
    while (number != 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

Console.WriteLine($"Сумма цифр равна {GetSumNumbers(InputNumber("Введите число: "))}");