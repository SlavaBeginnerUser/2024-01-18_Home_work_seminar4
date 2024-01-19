// Задача
// Назовём число «интересным» если его сумма цифр чётная
// Создать двумерный массив, состоящий из целых чисел. 
// Вывести на экран «интересные» элементы массива

// функция по созданию двумерного массива со значениями от 1 до 999
int[,] CreateMatrix(int rowCount, int colunsCount)
{
	int[,] matrix = new int[rowCount, colunsCount];  // задали массив из 3х строк и 5ти столбцов
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++) // построчно
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
		{
			matrix[i, j] = rnd.Next(1, 1000);
		}
	}
	return matrix;
}
int[,] matrix = CreateMatrix(3, 4); // создание массива 3х4 с помощью функции CreateMatrix 
ShowMatrix(matrix); // вывод массива с помощью функции ShowMatrix
foreach (int e in matrix)
{	
	if (IsInteresting(e) == true) // проверка интересное число или нет
	{
		Console.Write("Интересное число: ");
		Console.WriteLine(e);  // вывод результата проверки
	}
}
// функция по выведению массива, созданного функцией CreateMatrix
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
// проверка на числа "интересность" (сумма цивр числа четная)
bool IsInteresting(int value)
{
	int sumOfDigits = GetSumOfDigits(value);    // сумма цифр в числе
	if (sumOfDigits % 2 == 0)
	{
		return true;
	}
	else
	{
		return false;
	}
}
// функция по подсчету суммы цифр в числе
int GetSumOfDigits(int value)
{
	int sum = 0;
	while (value > 0)
	{
		sum = sum + value % 10;
		value = value / 10;
	}
	return sum;
}

