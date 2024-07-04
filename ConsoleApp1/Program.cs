using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {

        #region Q01
        //1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*
         * Pass by Value: means you are making a copy in memory of the actual parameter’s value that is passed in the stack.
          Pass by Reference: means you making a copy of the actual parameter’s alias or reference which points to the same space in stack. */

        static void PassingByValue(int x)
        {
            x = 20;
        }

        static void PassingByRef(ref int x)
        {
            x = 20;
        }


        #endregion


        #region Q02
        //2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Both will change the  value of the variable, but the difference is in the way each one works.

        static void RefByValue(int[] arr)
        {
            arr[0] = 100;
        }

        static void RefByRef(ref int[] arr)
        {
            arr[0] = 100;
        }

        #endregion


        #region Q03
        //3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        static void SumSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;

        }
        #endregion


        #region Q04
        //4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        static int SumDigit(int num) //123
        {
            int sum = 0;
            int moduls;
            while (num > 0)
            {
                moduls = num % 10; // 3 /  2  / 1 
                sum += moduls;  //3   / 3+2 =5  / 5 + 1=6 
                num = num / 10;  //12 /  1  /0.1
            }
            return sum;  //6 
        }

        #endregion


        #region Q05
        //5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion


        #region Q06
        //6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        static void MinMaxArray(ref int[] arr, ref int max, ref int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
        #endregion


        #region Q07
        //7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        static int NumFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {

                factorial *= i;
            }
            return factorial;
        }
        #endregion


        #region Q08
        //8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

        static void ChangeChar(ref string text, char letter, int position)
        {
            text = text.Remove(position, 1).Insert(position, letter.ToString());



        }
        #endregion




        static void Main(string[] args)

        {
            //Q01

            //int num = 10;
            //Console.WriteLine(num);
            //Console.WriteLine("================================");
            //PassingByValue(num);
            //Console.WriteLine(num);
            //Console.WriteLine("================================");
            //PassingByRef(ref num);
            //Console.WriteLine(num);

            //Q02

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr[0]);
            //Console.WriteLine("=========================");
            //RefByValue(arr);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine("=========================");
            //RefByRef(ref arr);
            //Console.WriteLine(arr[0]);


            // Q03
            //int sum = 0;
            //int sub = 0;
            //SumSub(10,20,out sum, out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);


            //Q04
            //int num;
            //int.TryParse( Console.ReadLine(), out num);
            //Console.WriteLine(SumDigit(num));


            //Q05
            //int num = 7;
            //Console.WriteLine(IsPrime(num));

            //Q06
            //int[] arr = { 9, 11, 19, 1, 2 };
            //int max=0;
            //int min =0;
            //MinMaxArray(ref arr, ref max, ref min);
            //Console.WriteLine(max);
            //Console.WriteLine(min);


            //Q07

            //Console.WriteLine(NumFactorial(9));



            //Q08
            //string str = "mkdkfmdkfd";
            //ChangeChar(ref str,'L', 0);
            //Console.WriteLine(str);
           

        }
    }
}
