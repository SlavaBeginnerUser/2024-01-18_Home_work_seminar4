// На основе символов строки (тип string) сформировать массив символов (тип char[]). 
// Вывести массив на экран. Указание Метод строки ToCharArray() не использовать. 
// Пример “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToChars(string str) // метод преобразования строки в массив
{
	char[] chars = new char[str.Length];
	for (int i = 0; i < str.Length; i++)
	{
		chars[i] = str[i]; // в массив заносим значение из строки
	}
	return chars;
}

void PrintArray(char[] chr)       // функция по выводу 1D массива со строчным знач
{
	foreach (char e in chr)
	{
		Console.Write(e + " ");
	}
}

string str = "Hello!";
char [] chr = StringToChars(str);  // создаем массив
PrintArray(chr);