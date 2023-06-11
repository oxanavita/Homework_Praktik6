// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел M: ");
// int M = int.Parse(Console.ReadLine());

// int count = 0;

// for (int i = 0; i < M; i++)
// {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());

//     if (number > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Количество чисел больше 0: " + count);



Console.Write("Введите количество чисел M: ");
int M = int.Parse(Console.ReadLine());

int[] numbers = new int[M];

for (int i = 0; i < M; i++)
{
    Console.Write("Введите число: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int count = CountPositiveNumbers(numbers);

Console.WriteLine("Количество чисел больше 0: " + count);

static int CountPositiveNumbers(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }

    return count;
}

