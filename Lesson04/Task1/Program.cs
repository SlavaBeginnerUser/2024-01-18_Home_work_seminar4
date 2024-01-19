// // двумерный массив
// int[,] matrix = new int[3, 5];  // задали массив из 3х строк и 5ти столбцов
// // заполнение массива случайными числами от 1 до 10
// Random rnd = new Random();         
// for (int i = 0; i < matrix.GetLength(0); i++) // построчно
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
// 	{
// 		matrix[i, j] = rnd.Next(1, 11);
// 	}
// }
// // выод созданного массива
// Console.WriteLine("Созданнный массив:");
// for (int i = 0; i < matrix.GetLength(0); i++) 
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++)
// 	{
// 		Console.Write($"{matrix[i,j]} "); // интерполяция строк
// 	}
// 	Console.WriteLine ();
// }

// функция по созданию двумерного массива со значениями от 1 до 10
int[,] CreateMatrix(int rowCount, int colunsCount)
{
	int[,] matrix = new int[rowCount, colunsCount];  // задали массив из 3х строк и 5ти столбцов
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++) // построчно
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
		{
			matrix[i, j] = rnd.Next(1, 11);
		}
	}
	return matrix;
}

// функция по выведению массива, созжанного функцией CreateMatrix
void ShowMatrix(int[,] matrix)
{
	Console.WriteLine("Созданнный массив:");
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

// создание массива 4х5 с помощью функции CreateMatrix 
int [,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix); // вывод массива с помощью функции ShowMatrix 