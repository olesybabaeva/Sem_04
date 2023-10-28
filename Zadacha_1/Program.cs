// напишите цикл, который принимает на вход
// два числа (А и В) и возводит А в натуральную
// степень В.
// 3,5 -> 243 (3^5)
// 2,4 -> 16 (2^4)

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} в степени {pow} = {GetPow(pow)}");

int GetPow (int B)
{
    int result = 0;
    for (int i = 1; i <= B; i++)
    {
       result = Convert.ToInt32(Math.Pow(number, i));
    }
    return result;
}