// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, 
// // что такого элемента нет: "Позиция по рядам выходит за пределы массива" или
// // "Позиция по колонкам выходит за пределы массива"
// // Позиции в массиве считать от единицы.

// // В коде, начальные условия:
// // int[,] numbers = new int[,] {
// // 	{1, 2, 3, 4},
// // 	{5, 6, 7, 8},
// // 	{9, 10, 11, 12}
// // };

// // int x = 2;
// // int y = 2;
// // Выводится: 6

// int[,] numbers = new int[,]
// {
// 	{1, 2, 3, 4},
// 	{5, 6, 7, 8},
// 	{9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

// int i = x - 1;
// int j = y - 1;

// if (i >= numbers.GetLength(0))
// {
// 	Console.Write("Позиция по рядам выходит за пределы массива");
// }
// else
// {
// 	if (j >= numbers.GetLength(1))
// 	{
// 		Console.Write("Позиция по колонкам выходит за пределы массива");
// 	}
// 	else
// 	{	
// 		Console.Write($"{numbers[i, j]} ");
// 	}
// }



// // Задайте двумерный массив. Напишите программу, которая поменяет местами 
// // первую и последнюю строку массива.
// // Начальные условия:
// // int[,] numbers = new int[,] {
// // 	{1, 2, 3, 4},
// // 	{5, 6, 7, 8},
// // 	{9, 10, 11, 12}
// // };
// // Выводится:
// // 9   10  11  12
// // 5   6   7   8
// // 1   2   3   4

// int[,] numbers = new int[,]
// {
// 	{1, 2, 3, 4},
// 	{5, 6, 7, 8},
// 	{9, 10, 11, 12}
// };

// int[,] numbersResult = numbers;
// int temp = 0;
// for (int i = 0; i < numbers.GetLength(1); i++)
// {
// 	temp = numbers[0, i];
// 	numbers[0, i] = numbersResult[numbers.GetLength(0)-1,i];
// 	numbersResult[numbers.GetLength(0)-1, i] = temp;
// }
// 	for (int i = 0; i < numbersResult.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < numbersResult.GetLength(1); j++)
// 			Console.Write($"{numbersResult[i, j]}\t");
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();




// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Начальные условия:
// // Начальные условия
// int[,] numbers = new int[,] {
// 	{1, 2, 3},
// 	{1, 1, 0},
// 	{7, 8, 2},
// 	{9, 10, 11}
// };
// Выводится: 1

using System.Globalization;

int[,] numbers = new int[,]
{
	{1, 2, 3},
	{1, 1, 0},
	{7, 8, 2},
	{9, 10, 11}
};
int minRowSum = 0;
int check = 0;
int numOfMinRowSum = 0;
for (int i = 0; i < numbers.GetLongLength(0); i++)
{
	int rowSum = 0;
	for (int j = 0; j < numbers.GetLongLength(1); j++)
		rowSum = rowSum + numbers[i, j];
	if (check == 0)
	{
		minRowSum = rowSum;
		check = 1;
	}
	if (minRowSum > rowSum)
		{
		minRowSum = rowSum;
		numOfMinRowSum =i;
		}
}
Console.WriteLine($"{numOfMinRowSum} ");