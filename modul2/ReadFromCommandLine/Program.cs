using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променлиши
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ( "Моля въведете а: " );
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ( "Резултатът а + b е:" + ( a + b ).ToString() + "\n\n\n");

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			//Задача 1 към Урок 6
			string test1 = "Hello";
			string test2 = " World";
			object prom = test1 + test2;
			string prom1 = Convert.ToString ( prom );

			Console.WriteLine (prom + ("\n"));
			Console.WriteLine (prom1 + ("\n"));

			//Задача 2 към урок 6
			int c = 0; 
			string word = null;
			string word1 = Convert.ToString (c);
			Console.WriteLine ("Моля въведете 1 число: ");
			c = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Моля въведете 1 дума: ");
			word = (Console.ReadLine ());

			Console.WriteLine ("Броят на символите е: " + ( word + word1).Length + ("\n\n"));
			//Как да изведа броя на символите?????


			Console.Write ( "Събиране с +=: " + test + ("\n\n"));

			test = test.Replace (", ", ";");
			Console.Write ( "Работа с Replace: " + test + ("\n\n"));

			Console.Write ( "3-ти знак: " + test.Split (';')[2] + ("\n\n"));


		}
	}
}
