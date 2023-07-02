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

Console.Write("Введите строку:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

int FindAvg(int[,] numbers)
{

for (int i = 0; i < numbers.GetLength(0); i++)
            
            if (pos1 < 0 | pos1 > numbers.GetLength(0) - 1 | pos2 < 0 | pos2 > numbers.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
                break;
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", numbers[pos1, pos2]);
                break;
            }

return (0);
}

int[,] newArray = GenerateArray2D(3,4);
PrintArray2D(newArray);
Console.WriteLine();
int output = FindAvg(newArray);
