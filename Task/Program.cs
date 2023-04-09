// Условие задачи:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArrayUserString(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void PrintArrayString(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountElementsFixLen(string[] arr, int len)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArrayWithElementsFixLen(string[] arr, int len, int count)
{
    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] startArray = CreateArrayUserString(size);
int countElementsFixLen = CountElementsFixLen(startArray, 3);
string[] finalArray = NewArrayWithElementsFixLen(startArray, 3, countElementsFixLen);
PrintArrayString(finalArray);