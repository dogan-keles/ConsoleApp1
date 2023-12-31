using System;

using System.Globalization;
using System.Text;
using System.Resources;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // *** DATA TYPES CONVERSION ***
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");
            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type: {strVal.GetType()}");
            double dblNum = 12.345;
            Console.WriteLine($"Integer: {(int)dblNum}");
            int intNum = 10;
            long longNum = intNum;

            Console.WriteLine("**************************");

            // *** FORMATTING OUTPUT ***

            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.45555);
            Console.WriteLine("Commas : {0:n4}", 2300);

            Console.WriteLine("**************************");
            
            // *** STRING FUNCTIONS  ***

            string randString = "This is a string";
            Console.WriteLine("String Length : {0}",
                randString.Length);
            Console.WriteLine("String contains is : {0}",
                randString.Contains("is"));
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0}",
                randString.Remove(10, 6));
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "short "));
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B", 
                StringComparison.OrdinalIgnoreCase));

            //Compare strings and ignore case
            //    < 0: str1 preceeds str2
            //    = : Zero 
            //    > 0 : str2 preeceds str1

            Console.WriteLine("A = a : {0}", 
               String.Equals("A","a",
               StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}",
                randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}",
                randString.Trim());
            Console.WriteLine("UpperCase : {0}",
                randString.ToUpper());
            Console.WriteLine("LowerCase : {0}",
               randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "Rabbit", "eating", "field");
            Console.Write(newString + "\n");
            Console.WriteLine(@"Exactly what I typed\n");
            Console.WriteLine("**************************");

            // *** ARRAYS  ***

            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("FavNums 0 : {0}", favNums[0]);
            string[] customers = {"Bob", "Sally", "Sue" };
            var employess = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());
            Console.WriteLine("Array size : {0}",
                randomArray.Length);
            for(int j = 0; j<randomArray.Length; j++)
            {
                Console.WriteLine("Array : {0} : Value : {1}",
                    j, randomArray[j]);
            }

            Console.WriteLine("**************************");


            // *** FUNCTIONS  ***
            static void PrintArray(int[] intArray, string mess)
            {
                foreach(int k in intArray)
                {
                    Console.WriteLine("{0} : {1}", mess, k);
                }
            }

            // *** END OF FUNCTIONS  ***


            string[,] custNames = new string[2, 2] { { "Bob", "Smaith" }, { "Sally", "Smith" } };
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 0));
            for (int j = 0; j<custNames.GetLength(0); j++)
            {
                for (int k = 0; k < custNames.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", custNames[j, k]);
                }
                Console.WriteLine();

            }

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach: ");
            Console.WriteLine("**************************");

            // *** MORE FUNCTIONS *** 
            Array.Sort(randNums);
            Array.Reverse(randNums);
           
            Console.WriteLine("1 at index : {0}",
            Array.IndexOf(randNums, 1));
            randNums.SetValue(0,2);
            Console.WriteLine(randNums);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("Copy to : {0}", m);
            }

            Console.WriteLine("**************************");

            // *** CONDITIONS *** 

            int age = 68;
            if((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if((age>13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            } 
            else if((age<14) || (age > 67))
            {
                Console.WriteLine("You should not work");
            }
            else
            {
                Console.WriteLine("Go to College");
                            }
            Console.WriteLine(age);

            bool canDrive = age >= 16 ? true : false;

            Console.WriteLine("**************************");

            // *** SWITCH *** 

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            string name2 = "Derek";
            string name3 = "Derek";
            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are same");
            }

            Console.WriteLine("**************************");

            // *** WHILE *** 

            int i = 1;
            while (i <= 10) {
            if (i % 2 == 0) {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("**************************");

            // *** DO WHILE *** 

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1,11);
            //int numberGuessed = 0;
            //Console.WriteLine("Random Num : ", secretNumber);
            //do
            //{
            //    Console.WriteLine("Enter a number between 1 and 10 : ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());
            //} while (secretNumber != numberGuessed);
            //Console.WriteLine("You guessed it, it was {0}", secretNumber);

            Console.WriteLine("**************************");

            // *** EXCEPTION HANDLER *** 

            static double DoDivision(double x, double y) 
            {
                if (y == 0)
                {
                    throw new System.DivideByZeroException();
                }
                return x / y;
            }
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            { Console.WriteLine(ex.Message);
                Console.WriteLine("You cant divide by zero");
                Console.WriteLine(ex.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Cleaning up"); }


            Console.WriteLine("**************************");

            // *** STRING BUILDER *** 

            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb2.Length);
            sb2.AppendLine("\nMore important text");
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-Us");
            string bestCust = "Doğan Keleş";
            sb2.AppendFormat(enUs, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb2.Equals(sb2));
            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());

            Console.WriteLine("**************************");

            // *** ACCESS SPECIFIER *** 
          
            sayHello();
            double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x = {0}", x);

            Console.WriteLine("**************************");

            // *** OUT PARAMETER ***
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 : {0}", solution);

            Console.WriteLine("**************************");

            // *** PASS BY REFERENCE ***

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num3 : {0} num4: {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num3 : {0} num4: {1}", num3, num4);

            Console.WriteLine("**************************");

            // *** PASSING UNKNOWN NUMBER OF PARAMETERS ***
            Console.WriteLine("1 + 2 + 3 : {0}", GetSumMore(1,2,3));
            PrintInfo(name: "Doğan Keleş", zipCode: 34435);


        }




        /// STATIC METHODS BELOW
      static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }
        
        
        
        static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        private static void sayHello()
        {
            string name = "";
            Console.Write("What is your name :");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

    }
    }

                          
