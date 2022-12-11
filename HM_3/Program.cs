
int[] randArray = new int[8];

for (int i = 0; i < randArray.Length; i++)
{
    randArray[i] = new Random().Next(1,9);
    Console.Write(randArray[i] + " ");
}



