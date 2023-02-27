/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не натуральное число. Повторите ввод");
        }
    }
    return result;
}

int Akkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    if ((m != 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}


int m = GetNumber("Введите первое число: ");
int n = GetNumber("Введите второе число: ");
Console.WriteLine($"Функция Аккермана равна {Akkerman(m, n)}");

