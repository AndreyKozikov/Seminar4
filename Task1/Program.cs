// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

long Exponentiation(int number, int degree)
{

    long power = number;
    for (int i = 1; i < degree; i++)
    {
        power = power * number;
    }
    return power;
}

int a = InputNumber("Введите число А: ");
int b = 0;
while (b < 1)
{
    b = InputNumber("Введите число B: ");
    if (b < 1)
    {
        Console.WriteLine("Число В должно быть натуральным. Повторите ввод."); ;
    }

}
Console.WriteLine(Exponentiation(a, b));