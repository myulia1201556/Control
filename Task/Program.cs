// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символ.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите размер массива (целое положительное число)");
int size = Convert.ToInt32(Console.ReadLine());

if (size <= 0)
{
    Console.WriteLine($"Некорректный ввод размера массива, попробуйте снова ");
}

string[] array1 = new string[size];
void CreatArray(string[] array1)
{
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array1[i] != " ")
            Console.WriteLine($"Введите {i + 1}-й элемент массива");
        array1[i] = Console.ReadLine()!;
        count++;
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

CreatArray(array1);
PrintArray(array1);