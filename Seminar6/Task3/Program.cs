// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных. 
// Пример 	“hello” => 2 		“world” => 1

// string hel ="HELLO!";
// hel.ToLower(); // преобразование верхн региста символов в нижний

int GetVowelsFromString(string str)
{
	int count = 0;
	string vowels = "aeiouy"; // переменная vowels содержит все англ гласные в нижнем регистре
	foreach (char e in str)  // проверка на наличие совпадений
	{
		if (vowels.Contains(e))
		{
			count++;
		}
	}
	return count;
}

Console.Write("Введите строку: ");
string str = Console.ReadLine();
int res = GetVowelsFromString(str.ToLower());  // применяем метод, сразу переводим символы в нижний регистр
Console.WriteLine($"Количество глассных в строке равно: {res}");