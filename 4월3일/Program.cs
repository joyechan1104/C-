NewMethod();

static void NewMethod()
{
/*    Console.WriteLine("03. do hhile 반복문");// 164p
    Console.WriteLine();
    //do while은 문장을 무조건 한번은 실행해야한다

    string dw;
    do
    {
        Console.WriteLine("입력(exit을 입력하면 종료): ");
        dw = Console.ReadLine();
    } while (dw != "exit");
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine("04. for 반복문");// 166p
    //for(;;) == while(true) 무한반복
    //167p 0~100까지의 숫자를 더한 결과
    //1*2*3*4 = 4팩토리얼 4!
    //코드 4-14 ~부터 ; ~까지

    //덧셈 
    int output = 0;
    for (int ii = 0; ii <= 30; ii++)
    {
        output += ii;
    }
    Console.WriteLine(output);
    Console.WriteLine();

    //곱셈 
    long output1 = 1; //초기값을 0으로하면 무엇으로 곱해도 0이된.
    for (long i1 = 1; i1 <= 20; i1++)
    {
        output1 *= i1;
    }
    Console.WriteLine(output1);
    Console.WriteLine();

    //문자출력
    for (int i3 = '가'; i3 <= '힣'; i3++)
    {
        Console.Write((char)i3);
    }
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine("05. 역 for 반복문");// 170p 감소하는 for문

    int[] intArray4 = { 1, 2, 3, 4, 5, 6 };
    for (int i4= intArray4.Length - 1; i4 >= 0; i4--)
    {
        Console.WriteLine(intArray4[i4]);
    }
    Console.WriteLine();
    Console.WriteLine();

*/
    Console.WriteLine("문1. 다음 while문을 for문으로 바꾸기"); // 저번 수업 파일에서 가꼬옴 

    int i = 0, sum = 0;
    Console.Write("배열의 크기 (개수) 입력 : ");
    int size = int.Parse(Console.ReadLine());
    int[] intArray1 = new int[size];

    Console.WriteLine("정수 {size}개 입력 : ");
    for (i = 0; i < intArray1.Length; i++)
    {
        Console.Write("{0} 번째 입력 : ", i + 1);
        intArray1[i] = int.Parse(Console.ReadLine());
        sum += intArray1[i];
    }

    Console.WriteLine();
    for (i = 0; i < intArray1.Length; i++)
    {
        Console.WriteLine("{0} 번째출력 : {1}", i + 1, intArray1[i]);
    }
    Console.Write("누적된수 : " + sum);
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine("문2. 역 for 문으로 바꾸기");// 문제 풀긴풀었는데 이해가안감 is this 코딩??

    int i2 = 0, sum2 = 0;
    Console.Write("배열의 크기 (개수) 입력 : ");
    int size2 = int.Parse(Console.ReadLine());
    int[] intArray2 = new int[size2];

    //입력
    Console.WriteLine("정수 {size}개 입력 : ");
    for (i2 = 0; i2 < intArray2.Length; i2++)
    {
        Console.Write("{0} 번째 입력 : ", i2 + 1);
        intArray2[i2] = int.Parse(Console.ReadLine());
        sum2 += intArray2[i2];
    }

    //출력
    Console.WriteLine();
    for (i2 = intArray2.Length - 1; i2 >= 0; i2--)
    {
        Console.WriteLine(intArray2[i2]);
    }

    Console.WriteLine();
    Console.WriteLine();



    Console.WriteLine("06. foreach 반복문");// 171p
    //foreach 반복문과 배열 반복문 내부에서 배열의 요소를 차례대로 출력 
    string[] array5 = { "사과", "배", "포도", "딸기", "바나나" };
    foreach (string item5 in array5)
    {
        Console.WriteLine(item5);
    }
    Console.WriteLine();

    //foreach 반복문과 var 키워드
    string[] array6 = { "사과", "배", "포도", "딸기", "바나나" };
    foreach (var item6 in array6)
    {
        Console.WriteLine(item6);
    }
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("07. 중첩 반복문");// 174p

    




}

