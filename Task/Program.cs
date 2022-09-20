// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символ.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// string[] array = new string[4] { "Hello", "2", "world", ":-)" };
// string[] array1 = new string[array.Length];

// void CreateNewArray(string[] arr, string[] arr1)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i].Length <= 3)
//         {
//             arr1[count] = arr[i];
//             count++;
//         }
//     }
// }

// void PrintArray(string[] array2)
// {
//     Console.Write("[");
//     for (int i = 0; i < array2.Length; i++)
//     {
//         Console.Write($"{array2[i] }");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
// CreateNewArray(array, array1);
// PrintArray(array1);


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