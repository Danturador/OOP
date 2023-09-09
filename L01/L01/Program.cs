using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool Bool = true;
			Console.WriteLine(Bool);
			byte Byte = byte.MaxValue;
			Console.WriteLine(Byte);
			sbyte Sbyte = sbyte.MaxValue;
			Console.WriteLine(Sbyte);
			short Short = short.MaxValue;
			Console.WriteLine(Short);
			ushort Ushort = ushort.MaxValue;
			Console.WriteLine(Ushort);
			int Int = int.MaxValue;
			Console.WriteLine(Int);
			uint Uint = uint.MaxValue;
			Console.WriteLine(Uint);
			long Long = long.MaxValue;
			Console.WriteLine(Long);
			ulong Ulong = ulong.MaxValue;
			Console.WriteLine(Ulong);
			char Char = 'a';
			Console.WriteLine(Char);
			float Float = 3.4f;
			Console.WriteLine(Float);
			double Double = 4.6d;
			Console.WriteLine(Double);
			decimal Decimal = 8.8m;
			Console.WriteLine(Decimal);


			Console.Write("Приведение типов:\n Неявное:\n");
			int number = 1566444811;
			long otherNumber = number;
			Console.WriteLine(otherNumber);

			Int = Short;
			Console.WriteLine(Int);

			Long = Byte;
			Console.WriteLine(Long);

			Short = Byte;
			Console.WriteLine(Short);

			Double = Float;
			Console.WriteLine(Double);

			Console.Write("\n Явное:\n");
			decimal bigNumber = 641231431.45m;
			int someNumber;
			someNumber = (int)bigNumber;
			Console.WriteLine(someNumber);

			Byte = (byte)Sbyte;
			Console.WriteLine(Byte);

			Int = (int)Uint;
			Console.WriteLine(Int);

			Short = (short)Ushort;
			Console.WriteLine(Short);

			Short = (short)Float;
			Console.WriteLine(Short);

			Console.Write("\n Упаковка:\n");
			object obj = Long;
			Long = 0;
			Console.WriteLine(obj);
			Console.WriteLine(Long);
			Console.Write("\n Распаковка:\n");
			Long = (long)obj;
			Console.WriteLine(Long);

			var someVarChar = 'd';
			var someVarNumber = 56452;
			Console.Write("type of someVarChar: " + someVarChar.GetType() + "\n" + "type of someVarNumber: " + someVarNumber.GetType());

			Console.Write("\n Nullable:\n");
			Nullable<short> shortNull = null;
			Console.WriteLine("shortNull = " + shortNull);

			//var varInt = 45562;
			//varInt = false;
			//varInt = 2.5f;

			//Задание 2 Строки
			string str1 = "Привет \"мир\"!";
			string str2 = @"Привет ""мир""!";
			Console.WriteLine("Задание a");
			Console.WriteLine("str1: " + str1);
			Console.WriteLine("str2: " + str2);

			Console.WriteLine("Задание b");
			// Создание три строк на основе String
			string firstString = "Привет";
			string secondString = "Мир!";
			string thirdString = "Это C#";

			// Сцепление строк
			string concatenatedString = firstString + secondString;
			Console.WriteLine("Сцепление строк: " + concatenatedString);

			// Копирование строки
			string copiedString = String.Copy(firstString);
			Console.WriteLine("Скопированная строка: " + copiedString);

			// Выделение подстроки
			string substring = concatenatedString.Substring(0, 6);
			Console.WriteLine("Подстрока: " + substring);

			// Разделение строки на слова
			string[] words = thirdString.Split(' ');
			Console.WriteLine("Разделение строки на слова: ");
			foreach (string word in words)
			{
				Console.WriteLine(word);
			}

			// Вставка подстроки в заданную позицию
			string originalString = "Маша имеет яблоко.";
			string insertedString = "красное ";
			int position = 6;
			string resultString = originalString.Insert(position, insertedString);
			Console.WriteLine("Изначальная строка: " + originalString);
			Console.WriteLine("Строка после вставки: " + resultString);

			// Удаление заданной подстроки
			string text = "Удаляемая подстрока";
			string substringToDelete = "ая под";
			string newText = text.Replace(substringToDelete, "");
			Console.WriteLine("Изначальная строка: " + text);
			Console.WriteLine("Строка после удаления подстроки: " + newText);

			// Интерполирование строк
			string name = "Олег";
			int age = 22;
			string interpolatedString = $"{name} - {age} лет";
			Console.WriteLine("Интерполированная строка: " + interpolatedString);


			Console.WriteLine("Задание c");
			string emptyString = string.Empty;
			string nullString = null;

			Console.WriteLine(string.IsNullOrEmpty(emptyString)); // Выводит True, потому что строка пустая
			Console.WriteLine(string.IsNullOrEmpty(nullString)); // Выводит True, потому что строка null

			// Примеры других возможностей работы с пустыми и null строками
			str1 = "";
			str2 = null;

			// Сравнение строк
			Console.WriteLine(str1 == str2); // Выводит False, потому что str1 - пустая строка, а str2 - null

			// Проверка на пустоту
			Console.WriteLine(str1.Length == 0); // Выводит True, потому что строка пустая
			Console.WriteLine(string.IsNullOrEmpty(str2)); // Выводит True, потому что строка null

			// Замена пустой или null строки
			string newString = str1 ?? "Default"; // Если str1 пустая или null, то newString будет равна "Default"

			// Объединение строк
			string combinedString = $"{str1}{str2}"; // combinedString будет равна null

			// Разделение строки на подстроки
			string[] substrings = str1.Split(' '); // substrings будет пустым массивом, потому что str1 не содержит пробелов

			Console.WriteLine("Задание d");
			StringBuilder sb = new StringBuilder("Hello, world!");

			// Удаление определенных позиций
			sb.Remove(7, 6);

			// Добавление новых символов в начало и конец строки
			sb.Insert(0, "Привет, ");
			sb.Append("!");

			string result = sb.ToString();
			Console.WriteLine(result);

			Console.WriteLine("Задание 3");
			Console.WriteLine("Задание a");
			int[,] matrix = new int[3, 3]
		{
			{ 1, 2, 3 },
			{ 4, 5, 6 },
			{ 7, 8, 9 }
		};

			// Вывод массива
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("Задание b");
			string[] array = { "строка 1", "строка 2", "строка 3", "строка 4", "строка 5" };

			//// Вывод содержимого массива на консоль
			Console.WriteLine("Содержимое массива:");
			foreach (string element in array)
			{
				Console.WriteLine(element);
			}

			//// Вывод длины массива
			Console.WriteLine("Длина массива: " + array.Length);

			//// Запрос позиции и значения от пользователя
			Console.Write("Введите позицию элемента: ");
			position = int.Parse(Console.ReadLine());

			Console.Write("Введите новое значение: ");
			string value = Console.ReadLine();

			//// Проверка наличия введённой позиции в массиве
			if (position >= 0 && position < array.Length)
			{
				// Изменение элемента массива
				array[position] = value;

				//	// Вывод измененного массива
				Console.WriteLine("Измененное содержимое массива:");
				foreach (string element in array)
				{
					Console.WriteLine(element);
				}
			}
			else
			{
				// Вывод сообщения об ошибке
				Console.WriteLine("Неверная позиция элемента!");
			}

			Console.WriteLine("Задание c");
			// Создание ступенчатого массива
			double[][] doubleArray = new double[3][];
			doubleArray[0] = new double[2];
			doubleArray[1] = new double[3];
			doubleArray[2] = new double[4];

			// Ввод значений с консоли
			for (int i = 0; i < doubleArray.Length; i++)
			{
				for (int j = 0; j < doubleArray[i].Length; j++)
				{
					Console.Write($"Введите значение для элемента [{i}][{j}]: ");
					doubleArray[i][j] = Convert.ToDouble(Console.ReadLine());
				}
			}

			// Вывод массива на экран
			Console.WriteLine("Введенный массив:");
			for (int i = 0; i < doubleArray.Length; i++)
			{
				for (int j = 0; j < doubleArray[i].Length; j++)
				{
					Console.Write($"{doubleArray[i][j]} ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("Задание d");
			var varArray = new[] { 1, 2, 3, 4, 5 };
			var varStr = "Hello World";
			Console.WriteLine(varArray[0]);
			Console.WriteLine(varStr);

			Console.WriteLine("Задание 4");
			Console.WriteLine("Задание a, b");
			var varTuple = (5, "строка", 'c', "еще строка", 1234567890UL);
			(int, string, char, string, ulong) tuple = (5, "строка", 'c', "еще строка", 1234567890UL);
			Console.WriteLine("varTuple: " + varTuple);
			Console.WriteLine("tuple: " + tuple);
			Console.WriteLine("tuple: " + varTuple.Item1 + varTuple.Item3 + varTuple.Item5);
			Console.WriteLine("tuple: " + tuple.Item1 + tuple.Item2 + tuple.Item4);

			Console.WriteLine("Задание c");
			var (a, b, c, d, e) = tuple;

			Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");
			//Вариант 2
			a = tuple.Item1;
			b = tuple.Item2;
			c = tuple.Item3;

			var (_, _, _, g, _) = tuple;

			Console.WriteLine($"g: {g}");

			Console.WriteLine("Задание d");
			Tuple<int, string> tuple1 = Tuple.Create(99, "hi");
			Tuple<int, string> tuple2 = Tuple.Create(99, "hi");
			if (tuple1.Equals(tuple2)) Console.WriteLine("Equals");
			tuple2 = Tuple.Create(100, "hi");
			Console.WriteLine(tuple1.Equals(tuple2));

			Console.WriteLine("Задание 5");
			//Задание a
			void CheckedMethod()
			{
				//Задание B
				checked
				{
					int maxValue = int.MaxValue;
					//int maxValue = int.MaxValue + 1; - ошибка
					Console.WriteLine("Max value using checked: " + maxValue);
				}
			}

			void UncheckedMethod()
			{
				//Задание B
				unchecked
				{
					int maxValue = int.MaxValue + 1;
					Console.WriteLine("Max value using unchecked: " + maxValue);
				}
			}

			Console.WriteLine("Задание c");
			CheckedMethod();

			UncheckedMethod();
			//- При использовании блока checked будет выброшено исключение System.OverflowException, так как при попытке присвоить переменной типа int значение, превышающее максимально допустимое, происходит переполнение. 
			//-При использовании блока unchecked переполнение не вызывает исключение, и переменная maxValue будет содержать минимальное значение для типа int.
		}
	}
}
