// Задача: Написать программу, 
// из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillingtArray(string[] arrayString) // заполнение нового массива по условию
{
    int z = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3) z++;
    }
    string[] resultArray = new string[z];
    z = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3) resultArray[z++] = arrayString[i];
    }
    return resultArray;
}

void PrintArray(string[] array) // выводит массив в консоль  
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
// string text = "Hello, 2, world, :-)";
// string text = "1234, 1567, -2, computer science"; // проверочный тест
string text = "Russia, Denmark, Kazan";// проверочный тест
string[] separators = new string[] { ", " };
string[] arr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); // Введённый текст -> массив строк. Разделение по запятой и пробелу

Console.Write($"[{text}] ->"); // вывод в консоль исходного массива
string[] fillingtArray = FillingtArray(arr);
PrintArray(fillingtArray);