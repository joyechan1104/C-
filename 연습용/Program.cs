using System;

class Program
{
    static void Main(string[] args)
    {
        int n, count, clap, total_clap = 0;

        Console.Write("369게임을 몇까지 할까요? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            count = 0;
            clap = 0;

            // 3, 6, 9 개수 세기
            int temp = i;
            while (temp > 0)
            {
                if (temp % 10 == 3 || temp % 10 == 6 || temp % 10 == 9)
                {
                    count++;
                }
                temp /= 10;
            }

            // 박수 개수 세기
            if (count == 0)
            {
                Console.Write($"{i} ");
            }
            else
            {
                clap = count;
                while (clap > 0)
                {
                    Console.Write("짝");
                    clap--;
                }
            }

            total_clap += count;
        }

        Console.WriteLine($"\\n총 박수 횟수: {total_clap}");
    }
}
