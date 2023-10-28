// напишите программу, которая принимает на вход
// число и выдает сумму цифр в числе
// 452 -> 11
// 83 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма цифр {number} -> {GetSum()}");

int GetSum ()
{
    int sum = 0;
    
    while (number > 0)
    {
       sum = sum + number % 10;
       number = number / 10; 
    }
    return sum;
    
}
