using System;
using System.Text;


namespace Console1
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Pls enter your name!");
            //string username = Console.ReadLine();
            //Console.WriteLine(" Your name!" + username);
            //Console.WriteLine(" Your name! {0}");


            //int i = 10;
            //Console.WriteLine("Min {0}", int.MinValue, int.MaxValue);

            //int n = 10;
            //int deno = 2;
            //int c = n / deno;
            //Console.WriteLine("Result= {0}", c);
            //Console.ReadKey();


            //int a = 20;
            //Console.WriteLine("Result= {0}", +a);

            //int num = 10;
            //int b = 20;
            //if (num == 20 || b == 20)
            //{
            //    Console.WriteLine("Two Number are mathcing.");
            //}
            //else
            //{
            //    Console.WriteLine("Two Number are not matching. Number must be Greater or less.");
            //}




            /// ---------------------
            /// Summary
            /// ----------------------




            /// if else vs Ternary operator 
            //int num = 10;

            //bool Isnum10;

            //if (num == 10)
            //{
            //    Isnum10 = true;
            //}
            //else
            //{
            //    Isnum10 = false;
            //}
            //Console.WriteLine("Number ==  10 is {0} ", Isnum10);

            //bool Isnum10 = num == 10 ? true : false;

            //Console.WriteLine("Number ==  10 is {0} ", Isnum10);




            /// -----------------------------------
            /// null and null coalescing operator 
            /// -----------------------------------



            //string Name = null;
            //int? i = null;
            //Console.WriteLine("Answers", Name);



            //bool? AreYouMajor = null;
            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("User is major");
            //}

            //else if (AreYouMajor.Value)
            //{
            //    Console.WriteLine("User is not major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the question");
            //}



            //int? TicketonSale = null;
            //int AvailTicket;

            //if (TicketonSale == null)
            //{
            //    AvailTicket = 0;
            //}
            //else
            //{
            //    AvailTicket = (int)TicketonSale;
            //}
            //Console.WriteLine("Availiable Tickets= {0}", AvailTicket);



            //Type conversion

            //int i = 100;
            //float f = i;
            //Console.WriteLine(f);

            //float f = 109716818.90f;

            //int i = (int)f;
            //int i = Convert.ToInt32(f);
            //Console.WriteLine(i);

            //string strNumb = "100";
            //int i = int.Parse(strNumb);
            //Console.WriteLine(i);

            //float[] numbers = { 1, 2.5f, 2100.08f };
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars.Length);

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers.Length);

            //int[,] two = { { 1, 4, 2 }, { 3, 6, 8 } };
            //Console.WriteLine(two[0, 2]);



            /// ---------------------------
            /// if else condition in c#.
            /// ---------------------------

            //Console.WriteLine("Please enter a number: ");

            //int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 1)
            //{
            //    Console.WriteLine("Your number is one");
            //}

            //else if (UserNumber == 2)
            //{
            //    Console.WriteLine("Your number is two");
            //}

            //else if (UserNumber == 3)
            //{
            //    Console.WriteLine("Your number is three");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not 1 or 2 or 3.");
            //}
            //Console.ReadKey();

            //if (UserNumber==10 || UserNumber==20 )
            //{
            //    Console.WriteLine("Your number is 10 or 20");
            //}
            //Console.ReadKey();

            //int YoE = 10;
            //string level;

            //switch(YoE)
            //{
            //    case 0:
            //        level = "Inexprerience!";
            //        break;

            //    case int i  when i > 0 && i<=2:
            //        level = "Beginner";
            //        break;

            //    case int i when i > 2 && i <= 5:
            //        level = "Professional";
            //        break;

            //    case int i when i > 10 && i <= 15:
            //        level = "Expert";
            //        break;

            //}
            //return level;


            //Console.WriteLine("Please number!");
            //int UserNumber = int.Parse(Console.ReadLine());

            //switch (UserNumber)
            //{
            //    case UserNumber= 10:
            //            Console.WriteLine("Your number is {0}", UserNumber);
            //        break;


            //    case UserNumber= 20:
            //            Console.WriteLine("Your number is {0}", UserNumber);
            //        break;

            //    default:
            //        Console.WriteLine("Your number is not 10, 20 ,30");
            //        break;
            //}

            int TotalCoffeeCost = 0;

            Console.WriteLine("1. Small , 2. Medium, 3. Large");
            int UserChoice= int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;

                case 2:
                    TotalCoffeeCost += 2;
                    break;

                case 3:
                    TotalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("Your choice {0} is invalid ", UserChoice);
                    break;           

            }

            Console.WriteLine("Thank you for shopping with us ");
            Console.WriteLine("Bill amount: {0} ",TotalCoffeeCost );


        }
    }
}
