NewMethod();

static void NewMethod()
{
    Console.WriteLine();
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

        Console.WriteLine("놀이공원 입장 무한반복문으로");
        string dw;
        do
        {
            Console.WriteLine("d입력(exit을 입력하면 종료): ");
            dw = Console.ReadLine();
            Console.Write("나이 입력 : ");
            int number4 = int.Parse(Console.ReadLine());

            if (number4 < 9)
            {
                Console.WriteLine("9세 미만의 어린이는 입장불가 입니다.");
            }

            Console.Write("키 입력 : ");
            int number5 = int.Parse(Console.ReadLine());

            if (number5 < 130)
            {
                Console.WriteLine("저속 롤러코스터 입장가능 입니다.");
            }
            else
            {
                Console.WriteLine("고속 롤러코스터 입장가능 입니다.");
            }

            Console.WriteLine();
        } while (dw != "exit");

        Console.WriteLine();
        Console.WriteLine();

    Console.WriteLine("1부터 입력받은 수 중에서 2의 배수이면서 3의 배수가 아닌 수를 모두 출력하는 프로그램을 작성하시오");

    for (; ; )
    {
        Console.Write("정수 하나 입력 : ");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 == 0)
        {

            Console.WriteLine("종료");
            break;
        }

        Console.WriteLine("1~20까지 2의 배수이면서 3의 배수가 아닌 수", num2);
        for (int i2 = 1; i2 <= num2; i2++)
            if (i2 % 2 == 0 && i2 % 3 == 0)
                Console.Write("{0,4}", i2);

        Console.WriteLine();
    }

/*   do
    {
        Console.WriteLine("입력(exit을 입력하면 종료): ");

        while (true)
        {
            Console.WriteLine("정수 하나 입력 (종료 : 0) : ");
            int num = int.Parse(Console.ReadLine());
            int[] intArrya = new int[];
            Console.WriteLine("1~20까지 2의 배수이면서 3의 배수가 아닌 수");
            Console.WriteLine();

            Console.WriteLine("정수 하나 입력 (종료 : 0) : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("1~10까지 2의 배수이면서 3의 배수가 아닌 수");

            Console.WriteLine("정수 하나 입력 (종료 : 0) : ");
            int num2 = int.Parse(Console.ReadLine());
        }
    } while (num != "exit"); 


    */
}

