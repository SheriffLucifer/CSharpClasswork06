//
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//
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

// void PrintString(string str)
// {
//     for (int i = 0; i < str.Length; i++)
//     {
//         Console.Write(str[str.Length - i - 1]);


//     }
// }

string DigitConvert(int x)
{
    string s = "";
    while (x > 0)
    {
        if (x % 2 == 1) s = s.Insert(0, "1"); //s=s+"1";
        else s = s.Insert(0, "0"); //s=s+"0";
        x = x / 2;
    }
    return s;
}

int n = GetNumberFromUser($"Введите целое число: ", "Ошибка ввода!");
string row = DigitConvert(n);
//PrintString(row);
Console.WriteLine(row);