// Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


void FillArray(int[] array)
{
    array[array.Length/2]=0;
    array[array.Length/2+1]=1;
    // array[array.Length/2-1]=1;
    for (int i=array.Length/2+2; i<array.Length; i++)
    {
        array[i]=(array[i-1])+(array[i-2]);
    }
    for (int i=0; i<array.Length/2-1; i++)
    {
        array[i]=array[array.Length-1-i];
        if (i%2==0) array[i]=array[i]*-1;
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Введите число k: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size*2];
Console.WriteLine("Массив чисел НегаФибоначчи:  ");
FillArray(array);
PrintArray(array);