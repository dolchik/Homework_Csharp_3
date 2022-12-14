// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int EntryDigit(string str) // метод считывает число введенное пользователем
{
    Console.Write(str);
    int userDigit = int.Parse(Console.ReadLine());
    return userDigit;
}
void checkPalindrom(int userDigit) // метод проверяет является ли число палиандромом
{
    int firstDigits = userDigit / 1000;
    int endDigits = (userDigit / 10 % 10 * 10) + userDigit % 10;
    
    if (firstDigits == endDigits) Console.WriteLine($"{userDigit} -> да");
    else Console.Write($"{userDigit} -> нет");
}

int userDigit = EntryDigit("Введите пятизначное число: ");
checkPalindrom(userDigit);

// Console.WriteLine(userDigit);

// int firstDigits = userDigit / 1000;
// Console.WriteLine(firstDigits);

// int endDigits = (userDigit / 10 % 10 * 10) + userDigit % 10;
// Console.WriteLine(endDigits);
