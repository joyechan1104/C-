using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

class program
{
    // 1번
    /*
        class Test // 함수 선언(정의)
        {
            public int Power(int x)
            {
                return x * x;
            }
        }

        static void Main(string[] args) // 함수 사용
        {
            Test test = new Test();
            Console.Write("숫자입력1 :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(test.Power(a));
            Console.Write("숫자입력2 :");
            int b = int.Parse(Console.ReadLine()); 
            Console.WriteLine(test.Power(b));
        }

        */

    // 2번
    private static void Main(string[] args)
    {
        //Test test = new Test();
        Console.Write("숫자입력3 :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(Power(a));
        minus1();
        minus2(10,20);
        Console.WriteLine("minus3() 메서드 = %d\n" + minus3());
        Console.WriteLine("minus4() 메서드 = %d\n" + minus4(5,20));
    }

    public static int Power(int x)
    {
        return x * x;
    }

    // 1.반환값x , 매개변수x
    void minus1()
    {
        int a = 5; int b = 3;
        Console.WriteLine("%d - %d = %d\n", a, b, a-b);
    }

    // 2.반환값x , 매개변수o
    void minus2(int a, int b)
    {
        Console.WriteLine("%d - %d = %d\n", a, b, a - b);
    }

    // 3.반환값o , 매개변수x
    void minus3()
    {
        int a = 5; int b = 3;
        return(a - b);
    }

    // 4.반환값o , 매개변수o
    void minus4(int a, int b)
    {
        return(a - b);
    }
}