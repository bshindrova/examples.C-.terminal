using System;

namespace modul2
{
	class MainClass
	{
		public static void Main ( )
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Module02 - Examples";
			string program_version = "1.0";

			//Събиране на числа
			a = 5; b = 10; sum = a + b;

			//Данни за програмата
			Console.WriteLine ( program_name );
			Console.WriteLine ("Версия: " + program_version + "\n\n");

			//Писане в конзола
			Console.Write(a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write ('=');
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\n Използване на += ");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\n Използване на -= ");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\n Използване на *= ");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\n Използване на ++ ");
			a ++ ;
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене " + "14/4" ); 
			Console.WriteLine ( 14/4 ); //резулт. 3, от целоч. делене на 14 и 4
			Console.WriteLine ("Остатък от делене "); 
			Console.WriteLine ((14 % 4).ToString ()); //% връща ост. от целоч. делене
		}
	}
}
