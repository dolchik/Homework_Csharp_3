// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int EntryDigit(string str)
{
    Console.Write(str);
    int userDigit = int.Parse(Console.ReadLine());
    Console.Write($"{userDigit} ->");
    return userDigit;
    
}

double findCube(int userDigit)
{
    int count = 1;
    double result = 0;
    
    while (count <= userDigit)
    {
        result = Math.Pow(count, 3);
        Console.Write($" {result}, ");
        count++;
    }
    return result; 
}

int userDigit = EntryDigit("Введите число N: ");
findCube(userDigit);
