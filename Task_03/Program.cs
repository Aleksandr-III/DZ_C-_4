// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int[] CreateRandomArray(int a, int start, int end)
{
    int[] RandomArray = new int[a];
    for (int i = 0; i < a; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
    Console.WriteLine();
}



Console.Write("Введите кол-во элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное сучайное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное сучайное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyRandomArray = CreateRandomArray(num, min, max);
ShowArray(MyRandomArray);
