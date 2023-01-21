//
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//

int n = GetNumberFromUser($"Введите целое число: ", "Ошибка ввода!");
string row = DigitConvert(n);
Console.WriteLine($"{n} -> {row}");

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

string DigitConvert(int x)
{
    string s = "";
    while (x > 0)
    {
        if (x % 2 == 1) { s = s.Insert(0, "1"); }
        else
        {
            s = s.Insert(0, "0");
        }
        x = x / 2;
    }
    return s;
}