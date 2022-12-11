
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA <=0 || numberB<=0) Console.WriteLine( "Числа некорректы");
else
    {int res = 1;
        for (int i = 1; i <= numberB; i++)
        {
            res = res * numberA;
   
        } 
    Console.WriteLine( numberA + " в степени " + numberB + " = "+ res);
 }