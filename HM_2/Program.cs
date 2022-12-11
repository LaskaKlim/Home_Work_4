
Console.WriteLine ("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int r = 0;
if (number > 0)
{
    while (number != 0)
    {
        r = number % 10;
        number = number / 10;
        sum = sum + r; 
    }
    Console.WriteLine("сумма чисел "+ sum);
}
else Console.WriteLine ("Введенное число некорректно");


