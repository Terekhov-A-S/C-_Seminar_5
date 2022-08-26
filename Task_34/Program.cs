// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
void fillArray(int[] array) // Заполнение массива
{
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array) // Печать четных чисел массива
{
    for (int count = 0; count < array.Length; count++)
    {
        if (array[count] % 2 == 0)
        {
            Console.Write($"{array[count]} ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("**Вас приветствует искусственный интеллект Core 2.0!**");
Console.WriteLine("Сейчас я создам массив и заполню его случайными трехзначными числами");
Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[num];

fillArray(newArray);
Console.Write("Четные числа в массиве, который я создал и заполнил случайными положительными числами: ");
printArray(newArray);
Console.WriteLine();



