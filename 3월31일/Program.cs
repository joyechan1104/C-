NewMethod();

static void NewMethod()
{
    Console.WriteLine();
    Console.WriteLine("01. 반복문과 배열"); //157p

    for (int i1 = 0; i1 < 1000; i1++) ;
    {
        Console.WriteLine("출력");
    }
    //기본적인 배열 생성방법 : 자료형[] 이름 = {자료,자료} / array : 정렬하다,배열하다
    int[] intArray = { 52, 634, 57, 41, 64 };
    long[] longArray = { 64, 78, 634, 865, 364 };
    float[] floatArray = { 1.0F, 2.0F, 3.0F };
    double[] doubleArray = { 1.0, 2.0, 3.0, 4.0 };
    char[] charArray = { '가', '나', '다', '라' };
    string[] stringArray = { "apple", "korea", "programig" };

    //배열 생성 후 요소에 접근
    //요소를 변경
    intArray[0] = 0;
    //요소를 출력
    Console.Write(intArray[0] + ", "); // 인덱스 : []안의 숫자
    Console.Write(longArray[1] + ", ");
    Console.Write(floatArray[2] + ", ");
    Console.Write(doubleArray[3] + ", ");
    Console.Write(charArray[3] + ", ");
    Console.WriteLine(stringArray[0]);

    //Length속성 / Length : 길이
    Console.Write(intArray.Length + ", ");
    Console.Write(longArray.Length + ", ");
    Console.Write(floatArray.Length + ", ");
    Console.Write(doubleArray.Length + ", ");
    Console.Write(charArray.Length + ", ");
    Console.WriteLine(stringArray.Length);

    //원하는 크기의 배열 생성 방법
    int[] array = new int[100];//기본 값으로 채워진다 숫자는 0 , 문자는 빈 문자열 , 객체는 null
    //요소의 길이를 출력
    Console.Write(array[0] + ", ");
    Console.WriteLine(array[99]);
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("02. while 반복문"); //162p while : ~하는 동안에
/*    //무한반복문
    while (true)
    {
        Console.WriteLine("무한반복");
    }
*/
    //while 반복문 이용
    int i2 = 0; //초기화 시켜주기
    int[] intArray2 = { 12, 23, 34, 45, 56 }; //배열 생성
    while (i2 < intArray2.Length) //반복문 수행
    {
        Console.WriteLine(i2 + 1 + "번째 출력" + intArray2[i2]); //출력
        i2++; //탈출을 위한 변수
    }
    Console.WriteLine();
    Console.WriteLine();
 
    /*    
        위의 코드는 C#언어로 작성된, 배열의 모든 원소를 출력하는 코드입니다.
    코드에서는 먼저 배열 `intArray2`와 반복문을 사용합니다.배열 `intArray2`는 5개의 정수를 저장하고 있습니다. 그리고 `while`반복문을 사용하여 배열의 모든 원소를 출력하고 있습니다.
    `while`반복문은 `i2` 변수가 `intArray2` 배열의 길이보다 작은 동안 반복됩니다. `Console.WriteLine` 함수를 호출하여 `i2 + 1`번째 원소를 출력하고 있습니다. `i2`는 0으로 초기화되며, 반복문이 한번 수행될 때마다 1씩 증가됩니다.
    따라서 위의 코드는 배열 `intArray2`의 모든 원소를 출력하는 코드입니다.
    */



    int i = 0, sum = 0;
    //    1. 코드 첫 부분에서는 변수 i와 sum을 선언하고 0으로 초기화합니다. 이는 뒤에서 사용할 변수들로, 각각 반복문에서 사용할 인덱스와 정수의 누적 합을 저장하기 위한 변수입니다.
    Console.Write("배열의 크기 (개수) 입력 : ");
    int size = int.Parse(Console.ReadLine());
    //    2. 사용자로부터 배열의 크기를 입력받아 변수 size에 저장합니다. 이때, Console.ReadLine()을 사용하여 사용자가 입력한 값을 문자열로 받아와 int.Parse()를 사용하여 정수로 변환합니다.
    int[] intArray1 = new int[size];
    //    3.이제, 크기가 size인 intArray1이라는 배열을 생성합니다.이 배열은 사용자가 입력한 정수들을 저장할 공간입니다.

    Console.WriteLine("정수 {size}개 입력 : ");
    //int[] intArray = { 52,235,46,75,346 }; 입력을 받을거니 필요 ㄴㄴ
    while (i < intArray1.Length)
    {
        Console.Write("{0} 번째 입력 : " , i + 1);
        intArray1[i] = int.Parse(Console.ReadLine());
        sum += intArray1[i];
        i++;
    }
    //    4.사용자에게 배열의 크기만큼 정수를 입력받아 배열에 저장합니다. 이때, while 반복문을 사용하여 배열에 입력받은 정수를 순서대로 저장하고, 각 정수를 입력받을 때마다 sum 변수에 누적하여 더합니다.

Console.WriteLine();
    i = 0;
    while (i < intArray1.Length)
    {
        Console.WriteLine("{0} 번째출력 : {1}", i + 1 , intArray1[i]);
        i++;
    }
    //    5. 배열에 저장된 정수들을 출력합니다. 이때, while 반복문을 사용하여 배열의 모든 원소를 출력합니다.
    Console.Write("누적된수 : " + sum);
    //    6. 배열에 저장된 정수들의 누적 합을 출력합니다. 이때, Console.Write를 사용하여 "누적된 수 : "와 sum의 값을 출력합니다.
    Console.WriteLine();
    Console.WriteLine();



    int a = int.Parse(Console.ReadLine());


}

