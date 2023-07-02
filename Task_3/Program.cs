void PrintArray2D(int[,] numbers)
{
for (int i = 0; i < numbers.GetLength(0); i++)
{
for (int j = 0; j < numbers.GetLength(1); j++)
{
System.Console.Write($"{numbers[i,j]}\t");
}
System.Console.WriteLine();
}
}

int[,] GenerateArray2D(int rows, int columns)
{
int[,] numbers = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < numbers.GetLength(0); i++)
{
for (int j = 0; j < numbers.GetLength(1); j++)
{
numbers[i, j] = rnd.Next(0, 10);
}
}
return numbers;
}


double FindAvg(int[,] numbers)
{
double sum = 0;
double avg = 0;
for (int i = 0; i < numbers.GetLength(1); i++)
{
for (int j = 0; j < numbers.GetLength(0); j++)
{
sum += numbers[j,i];
avg = sum / numbers.GetLength(0);

}
System.Console.WriteLine(avg);
sum=0;

}
return 0;

}
int[,] newArray = GenerateArray2D(3,4);
PrintArray2D(newArray);
Console.WriteLine();

double output = FindAvg(newArray);
