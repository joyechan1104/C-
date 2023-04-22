using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("피라미드 다음 중첩반복문을 while문으로 바꾸기");
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < i + 1; j++)
        //        Console.Write("*");
        //    Console.Write("\n");
        //}

        Console.WriteLine();

        int i1 = 0; int output1 = 0;
        string[] stringArray1 = new string[10];
        while (i1 < stringArray1.Length)
        {
            output1 += i1;
            Console.WriteLine(output1);
            i1++;
        }

        int i = 0;
        while (i < 10)
        {
            int j = 0;
            while (j < i + 1)
            {
                Console.Write("*");
                j++;
            }
            Console.Write("\n");
            i++;
        }
        Console.WriteLine();

        Console.WriteLine("역피라미 다음 중첩반복문을 while문으로 바꾸기-2");

        for (int i3 = 0; i3 < 10; i3++)
        {
            for (int j3 = 0; j3 < 10 - i3; j3++)
                Console.Write(' ');
            for (int j3 = 0; j3 < i3 + 1; j3++)
                Console.Write("*");
            Console.Write("\n");
        }
        Console.WriteLine();

        Console.WriteLine("188p 조건문을 if else if 로 바꾸기");
 
        while (true)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로이동");
                    break;
                case ConsoleKey.X:
                    Console.WriteLine("종료");
                    return; // or break; if used inside a method
            }
        }
        Console.WriteLine();

        while (true)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("위로이동");
            }
            else if (info.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("오른쪽으로이동");
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("아래로이동");
            }
            else if (info.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("왼쪽으로이동");
            }
            else if (info.Key == ConsoleKey.X)
            {
                Console.WriteLine("종료");
                break;
            }
        }
    }
}