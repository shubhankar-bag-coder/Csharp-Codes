using System;

namespace Easy_Calc
{

class Program
	{

		public static void Addition(int fno, int sno)
		{
			Console.WriteLine("Addition is:" + (fno + sno));
		}

		public static void Subtraction(int fno, int sno)
		{
			Console.WriteLine("Subtraction is:" + (fno - sno));
		}

		public static void Division(int fno, int sno)
		{
			Console.WriteLine("Division is:" + ((float)fno / sno));
		}

		public static void Multi(int fno, int sno)
		{
			Console.WriteLine("Multiplication is:" + ((float)fno * sno));
		}


		// Below Main Method

		static void Main(String[] args)
        {
			int fno, sno, result;
			string symbol_choice,value_continue;

            do
            {
				Console.WriteLine("Enter first number");
				fno= Convert.ToInt32(Console.ReadLine());


				Console.WriteLine("Enter second number");
				sno = Convert.ToInt32(Console.ReadLine());


				Console.WriteLine("Enter symbol for operation:");
				Console.WriteLine(" +, -, /, * ");
				symbol_choice = Console.ReadLine();

                switch (symbol_choice)
                {
					case "+":
						Addition(fno, sno);
						break;

					case "-":
						Subtraction(fno, sno);
						break;
					case "/":
						Division(fno, sno);
						break;
					case "*":
						Multi(fno, sno);
						break;
					default:
						Console.WriteLine("Pleae enter valid Symbols for operation:");
						break;
				}
				Console.WriteLine("Press y for continue & press n for Exit");
				value_continue = Console.ReadLine();

			}while(value_continue=="y"  || value_continue=="Y");

        }
}
}