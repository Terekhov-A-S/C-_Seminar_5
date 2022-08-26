// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
void fillArray(int[] array) // Заполнение массива
{
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(-999999, 1000000);
    }
}

void printArray(int[] array) // Печать чисел массива, стоящих на нечетных позициях
{
    int sum = 0;
    for (int count = 0; count < array.Length; count++)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{array[count]}, ");
            sum = sum + array[count];
        }
    }
    Console.WriteLine($"cумма этих чисел равна: {sum}");
}

Console.WriteLine("**Вас приветствует искусственный интеллект Core 2.0!**");
Console.WriteLine("Сейчас я создам массив и заполню его случайными числами");
Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[num];

fillArray(newArray);
Console.Write("Числа в массиве, который я создал, стоящие на нечетных позициях: ");
printArray(newArray);
Console.WriteLine();

