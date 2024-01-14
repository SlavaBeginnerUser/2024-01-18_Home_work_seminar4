// вывод квадрата числа от 1 до N (N = 5, 10, 15) 
void PrintSquares(int limit)
{
	int i = 1;
	while (i<= limit)
	{
		Console.Write($"{i*i} ");
		i++;
	}
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);