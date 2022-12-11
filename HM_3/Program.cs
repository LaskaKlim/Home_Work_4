
int[] randArray = new int[8];
Console.Write("[ ");
for (int i = 0; i < randArray.Length; i++)
{
    randArray[i] = new Random().Next(1,99);
    Console.Write(randArray[i] + " ");
}
Console.Write("]");



