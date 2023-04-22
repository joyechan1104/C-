NewMethod();

static void NewMethod()
{
    Console.WriteLine();

    Random r = new Random();

    int[] intArray = new int[6];

    for (int i = 0; i < 6; i++)
        intArray[i] = r.Next(1, 46); // 1~45까지의 숫자

    Console.WriteLine("생성된 6개의 랜덤한 숫자 출력:");

    //foreach (int value in intArray)
    //  Console.Write("{0,5}", value);
    for (int i = 0; i < 6; i++) // (c+c)+(c+v)
    Console.WriteLine("{0,5}", intArray[i]); //value가 필요없어짐, 자리를 intArrya가 대체
    Console.WriteLine();

    Console.WriteLine("놀이공원 입장 무한반복문으로");
    do
    {
        Console.Write("나이 입력 : ");
        string num = Console.ReadLine();

        if (num == "exit")
        {
            break;
        }
        int number1 = int.Parse(num); // 브레이크 다음에 int.parse를 붙인

        if (number1 < 9)
        {
            Console.WriteLine("9세 미만의 어린이는 입장불가 입니다.");
        }

        Console.Write("키 입력 : ");
        int number2 = int.Parse(Console.ReadLine());

        if (number2 < 130)
        {
            Console.WriteLine("저속 롤러코스터 입장가능 입니다.");
        }
        else
        {
            Console.WriteLine("고속 롤러코스터 입장가능 입니다.");
        }
    } while (true);
    Console.WriteLine();

    Console.WriteLine("1부터 입력받은 수 중에서 2의 배수이면서 3의 배수가 아닌 수를 모두 출력");
    for (; ; )
    {
        Console.WriteLine("정수 하나 입력 : ");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("종료");
            break;
        }

        Console.WriteLine("1~{0}까지 2의 배수이면서 3의 배수가 아닌 수", num2);
        for (int i2 = 1; i2 <= num2; i2++)
        if (i2 % 2 == 0 && i2 % 3 != 0) // 부정연산 !=
        Console.WriteLine("{0,4}", i2);
    }
    Console.WriteLine();

    Console.WriteLine("1부터 입력받은 수 중에서 2의 배수이면서 3의 배수인 수를 모두 출력");
    for (; ; )
    {
        Console.Write("정수 하나 입력 : ");
        int num3 = int.Parse(Console.ReadLine());

        if (num3 == 0)
        {
            Console.WriteLine("종료");
            break;
        }

        Console.WriteLine("1~20까지 2의 배수이면서 3의 배수인 수", num3);
        for (int i3 = 1; i3 <= num3; i3++)
        if (i3 % 2 == 0 && i3 % 3 == 0) // ==
        Console.WriteLine("{0,4}", i3);
    }
}

