//
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//

int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
int[] Fib_Array = CreateArray(n);
PrintArray(Fib_Array, n);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] CreateArray(int size)
{
    int[] res = new int[size];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < size; i++)
    {
        res[i] = res[i - 2] + res[i - 1];
    }
    return res;
}

void PrintArray(int[] arr, int n)
{
    Console.Write($"Если N = {n} -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}