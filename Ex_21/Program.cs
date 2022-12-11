// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int EntryData(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double calcDistunce(int x1, int y1, int z1, int x2, int y2, int z2)
{
double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
return result;
}

int x1 = EntryData("Введите координаты x1: ");
int y1 = EntryData("Введите координаты y1: ");
int z1 = EntryData("Введите координаты z1: ");
int x2 = EntryData("Введите координаты x2: ");
int y2 = EntryData("Введите координаты y2: ");
int z2 = EntryData("Введите координаты z2: ");

double result = calcDistunce(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {result}");
