//  Напишите цикл, который принимает на вход два числа (A и B) и возводит 
//  число A в натуральную степень B. (т.е нужно решить задачу без использования Math.Pow)

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 1; i <= numberB; i++)
{
    res = res * numberA;
   
} 
 Console.WriteLine( numberA + " в степени " + numberB + " = "+ res);