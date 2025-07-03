using System;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Output:
            //*****
            //****
            //***
            //**
            //*
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        for (int j = i; j <= 5; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }


            //Output:
            //*
            //**
            //***
            //****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Output:
            //*****
            //*****
            //*****
            //*****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Output:
            //1
            //12
            //123
            //1234
            //12345
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Output:
            //    *
            //    **
            //    ***
            //    ****
            //    *****
            //    ****
            //    ***
            //    **
            //    *

            //for (int i = 1; i <= 9; i++)
            //{
            //    int k = i <= 5 ? i : 10 - i;

            //    for (int j = 1; j <= k; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}





            //Output:
            //    *
            //   **
            //  ***
            // ****
            //*****
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j <= 5 - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }





        }
}
}




