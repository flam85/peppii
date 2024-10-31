// See https://aka.ms/new-console-template for more information
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Вызываем метод для подсчета суммы нечётных элементов
int sum = SumOfOddElements(array);

// Выводим результат
Console.WriteLine($"Сумма нечётных элементов массива: {sum}");
    

    static int SumOfOddElements(int[] arr)
{
    int sum = 0;

    // Проходим по элементам массива
    foreach (int num in arr)
    {
        // Проверяем, является ли элемент нечётным
        if (num % 2 != 0)
        {
            sum += num; // Добавляем нечётный элемент к сумме
        }
    }

    return sum; // Возвращаем итоговую сумму
}
Console.ReadKey();