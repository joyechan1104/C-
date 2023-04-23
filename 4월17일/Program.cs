using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("랜덤하게 생성할 수의 개수 : ");
        int N = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] arr = new int[N];

        Console.Write("랜덤값출력: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = rand.Next(0, 100);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        int max = arr[0], min = arr[0];
        for (int i = 1; i < N; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("최대값: " + max + " 최소값: " + min);
    }
}