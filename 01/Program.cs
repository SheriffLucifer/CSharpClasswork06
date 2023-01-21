Console.Clear();

int ab = GetNumberFromUser($"Введите любое целое число A: ", "Ошибка ввода!");
int bc = GetNumberFromUser($"Введите любое целое число B: ", "Ошибка ввода!");
int ca = GetNumberFromUser($"Введите любое целое число C: ", "Ошибка ввода!");

bool checkTriangle = CheckTriangle(ab, bc, ca);
Console.WriteLine($"Со сторонами {ab}, {bc}, {ca} треугольник -> {(checkTriangle ? "Существует" : "Не существует")}");

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

bool CheckTriangle(int ab, int bc, int ca)
{
    if ((ab < (bc + ca)) && (bc < (ab + ca)) && (ca < (ab + bc)))
    {
        return true;
    }
    else
    {
        return false;
    }
}