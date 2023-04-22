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

    //while 반복문 이용
    int i2 = 0; //초기화 시켜주기
    int[] intArray2 = { 12, 23, 34, 45, 56 }; //배열 생성
    while (i2 < intArray2.Length) //반복문 수행
    {
        Console.WriteLine(i2 + 1 + "번째 출력" + intArray2[i2]); //출력
        i2++; //탈출을 위한 변수
    }
    Console.WriteLine();

    //실습
    int i = 0, sum = 0;
    Console.Write("배열의 크기 (개수) 입력 : ");
    int size = int.Parse(Console.ReadLine());
    int[] intArray1 = new int[size];

    Console.WriteLine("정수 {size}개 입력 : ");
    while (i < intArray1.Length)
    {
        Console.Write("{0} 번째 입력 : " , i + 1);
        intArray1[i] = int.Parse(Console.ReadLine());
        sum += intArray1[i];
        i++;
    }

Console.WriteLine();
    i = 0;
    while (i < intArray1.Length)
    {
        Console.WriteLine("{0} 번째출력 : {1}", i + 1 , intArray1[i]);
        i++;
    }
    Console.Write("누적된수 : " + sum);
}

