// Задайте двумерный массив.
// Сформируйте новый одномерный массив, состоящий из 
// средних арифметических значений по строкам двумерного массива. 
// Пример 
// 2 3 4 3   
// 4 3 4 1    =>  [3 3 5] 
// 2 9 5 4

int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
{
	int[,] array3 = new int[rows, collums];
	Random rnd = new Random();
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < collums; j++)
			array3[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
	return array3;
}

void ShowArray2D(int[,] matrix)                 // функция по выводу 2D массива
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

void PrintArray(double[] massiv)       // функция по выводу 1D массива с веществ знач
{
	for (int i = 0; i < massiv.Length; i++)
	{
		Console.Write($"{massiv[i]} ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

double[] AvgArray(int[,] array3)    // функция решения для задачи
{
	double[] avgMeans = new double[array3.GetLength(0)];    // одномерный массив с вещественным типом данных
	for (int i = 0; i < array3.GetLongLength(0); i++)
	{
		double currentSum = 0;
		for (int j = 0; j < array3.GetLongLength(1); j++)
		{
			currentSum = currentSum + array3[i, j];
		}
		currentSum = currentSum / array3.GetLength(1);
		avgMeans[i] = currentSum;
	}
	return avgMeans;
}

int[,] arrayTask3 = CreateArray2D(4, 3);    // задаем размер массива (4 строки и 3 столбца)
ShowArray2D(arrayTask3);                    // показываем массив
double[] avgMeansArr = AvgArray(arrayTask3);
Console.WriteLine("Результат: ");
PrintArray(avgMeansArr);		// вывод через функцию
// или вывод через foreach:
foreach (double val in avgMeansArr)
{
	Console.Write(Math.Round(val, 3) + " "); // округление до 3го знака после запятой
	Console.WriteLine();
}