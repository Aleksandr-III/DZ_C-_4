// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int z = 0;
    

    while ( num > 0)
    {
        z += num % 10;
        num /= 10;
    }


Console.WriteLine($"Сумма чисел равна {z} ");