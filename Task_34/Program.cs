/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int InPut(string text) //Функция для ввода числа.
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = InPut("Enter the lenght of the array: "); // Длина массива.
int left = InPut("Enter the left side: "); // Минимальное число массива.
int right = InPut("Enter the right side: "); // Максимальное число массива.
int quantity = 0; // Количество четных чисел в массиве.
int[] Array(int size, int left, int right) // Функция для заполнения массива и определения количества четных чисел в массиве.
{
    Random rand = new Random(); // Объект класса Random. 
    int[] array = new int[size]; // Объявление массива.

    for(int i = 0; i < array.Length; i++) // Цикл для заполнения массива
    {
        array[i] = rand.Next(left, right); // Инициализация элемента массива случайным числом.
        if(array[i] % 2 == 0) quantity++; // Проверка на четность, и заполнение переменной quantity.
    }
    return array; // Возвращение массива.

}

int[] array = Array(size, left, right+1); // Получение результата функции в переменную array.
System.Console.Write("[" + string.Join(", ", array) + $"] -> {quantity}"); // Вывод массива и количества четных элементов в нем.