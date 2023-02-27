/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result>0)
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

void GetSum (int m, int n, int sum)
{
    int temp = m;
    if (m>n) 
    {
        temp = n;
        n = m;
        m = temp;
    }
    if(m == n) System.Console.WriteLine($"{sum + m}");
    else 
    {
        sum+=n;
        GetSum(m, n-1, sum);
    }
}

int m = GetNumber("Введите первое число: ");
int n = GetNumber("Введите второе число: ");
int sum = 0;
GetSum(m,n,sum);
