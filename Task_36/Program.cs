/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int InPut(string text) //Функция для ввода числа.
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = InPut("Enter the lenght of the array: "); // Длина массива.
int left = InPut("Enter the left side: "); // Минимальное число массива.
int right = InPut("Enter the right side: "); // Максимальное число массива.
int sum = 0; // Сумма элементов, стоящих на нечётных позициях.
int[] Array(int size, int left, int right) // Функция для заполнения массива и определения суммы элементов, стоящих на нечётных позициях.
{
    Random rand = new Random(); // Объект класса Random. 
    int[] array = new int[size]; // Объявление массива.

    for(int i = 0; i < array.Length; i++) // Цикл для заполнения массива
    {
        array[i] = rand.Next(left, right); // Инициализация элемента массива случайным числом.
        if(i % 2 != 0) sum += array[i]; // Проверка на нечётность, и заполнение переменной sum.
    }
    return array; // Возвращение массива.

}

int[] array = Array(size, left, right+1); // Получение результата функции в переменную array.
System.Console.Write("[" + string.Join(", ", array) + $"] -> {sum}"); // Вывод массива и суммы элементов, стоящих на нечётных позициях.