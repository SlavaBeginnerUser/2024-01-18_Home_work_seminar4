// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример 
// 2 3 4 3    
// 4 3 4 1    =>  2 + 3 + 5 = 10 
// 2 9 5 4

int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
{
	int[,] array2 = new int[rows, collums];
	Random rnd = new Random();
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < collums; j++)
			array2[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
	return array2;
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

int MainDiagSum(int[,] array2)          // функция по решению задачи 1й метод
{
	int mainDiagSum = 0;
	for (int i = 0; i < array2.GetLength(0); i++)
	{
		for (int j = 0; j < array2.GetLength(1); j++)
		{
			if (i == j)
				mainDiagSum = mainDiagSum + array2[i,j];
		}
	}
	return mainDiagSum;
}

int MainDiagSum2(int[,] array2)         // функция по решению задачи 2й метод
{
	int mainDiagSum = 0;
	if(array2.GetLength(0)<= array2.GetLength(1))
	{
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			mainDiagSum += array2[i, i]; // += array2[i,i] тождественно = mainDiagSum + array2[i,i]
		}
	}
	else 
	{
		for (int i = 0; i < array2.GetLength(1); i++)
		{
			mainDiagSum += array2[i, i];
		}
	}
	return mainDiagSum;
}

int[,] arrayTask2 = CreateArray2D(4, 3);    // задаем размер массива
ShowArray2D(arrayTask2);					// показываем массив
int sumMainDiag = MainDiagSum(arrayTask2);	// решение 1м методом
int sum2MainDiag = MainDiagSum2(arrayTask2);// решение 2м методом
Console.WriteLine($"Результат 1-го метода: {sumMainDiag} ");
Console.WriteLine($"Результат 2-го метода: {sum2MainDiag} ");