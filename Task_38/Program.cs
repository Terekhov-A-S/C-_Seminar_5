//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
void fillArray(int[] array) // Заполнение массива
{
    for (int count = 0; count < array.Length; count++)
    {
        array[count] = new Random().Next(-999999, 1000000);
    }
}
Console.WriteLine("**Вас приветствует искусственный интеллект Core 2.0!**");
Console.WriteLine("Сейчас я создам массив и заполню его вещественными числами");
Console.Write("Задайте длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[num];
fillArray(newArray);
int min = 0;
int max = 0;
for (int cnt = 0; cnt < newArray.Length; cnt++)
{
    if (newArray[cnt] < min)
    {
        min = newArray[cnt];
    }
    if (newArray[cnt] > min)
    {
        max = newArray[cnt];
    }
}
int numCheck = max - min;
Console.WriteLine($"Минимальное число: {min}, максимальное число: {max} ");
Console.WriteLine($"Разница иежду ними: {numCheck} ");
