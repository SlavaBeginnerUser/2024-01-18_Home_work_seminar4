// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Пример 
// 2 3 4 3    			4 3 16 3
// 4 3 4 1    => 		4 3 4  1
// 2 9 5 4 				4 9 25 4

// int [,] matrix = new int [rows,collums]; - создание 2х мерного массива
// array.Length - посчитает все подряд элементы в массиве
// array.GetLength(0) - посчитает все элементы в строке
// array.GetLength(1) - посчитает все элементы в столбце

int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
{
	int[,] array1 = new int[rows, collums];
	Random rnd = new Random();
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < collums; j++)
			array1[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
	return array1;
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

int[,] SquareElem(int[,] firstArray)        // метод решенияя условия задачи
{
	for (int i = 0; i < firstArray.GetLength(0); i++)
	{
		for (int j = 0; j < firstArray.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				firstArray[i, j] *= firstArray[i, j];   // возведение в квадрат
														// *= firstArray[i, j] соответствует firstArray[i, j] * firstArray[i, j]
			}
		}
	}
	return firstArray;
}

int[,] arrayTask1 = CreateArray2D(4, 5);    // задаем размер массива 4 строки х 5 столбцов
ShowArray2D(arrayTask1);
int[,] resultArrayTask1 = SquareElem(arrayTask1);
Console.WriteLine("Результат: ");
ShowArray2D(resultArrayTask1);