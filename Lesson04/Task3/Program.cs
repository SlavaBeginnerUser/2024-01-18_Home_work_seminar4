// Задача
// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.


string GetLettersFromString(string s)
{
	string letters = "";     // Ввод строки 
	foreach (char e in s)    // Проход по элементам строки
	{
		if (char.IsAsciiLetter(e) == true)   // является ли проверяемый элемент буквой
		{
			letters = letters + e;   // дописываем подходящий элемент к новой строке 
		}
	}
	return letters;
}

string str = Console.ReadLine();    // ввод строки
string result = GetLettersFromString(str);  // вызов функции GetLettersFromString
Console.WriteLine(result);          
