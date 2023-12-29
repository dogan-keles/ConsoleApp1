using System;

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

            // *** ARRAYS  ***
        }
    }
    }