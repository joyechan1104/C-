NewMethod();

static void NewMethod()
{
    Console.WriteLine("04 변수");
    /*정수변수생성 int, long 80p*/
    int a = 273;
    int b = 52;

    Console.WriteLine(a + b);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine(a / b);
    Console.WriteLine(a % b);
    Console.WriteLine();

    /*오버플로우 82p*/
    int c = 2147483640;
    int d = 55273;
    Console.WriteLine(c + d);

    int e = 2000000000;
    int f = 1000000000;
    Console.WriteLine(e + f);
    Console.WriteLine();

    /*자료형 변환 unsinged 82p*/
    uint unsignedInt = 4147483647;
    ulong unsignedLong = 11223372036854775808;
    Console.WriteLine(unsignedInt);
    Console.WriteLine(unsignedLong);
    Console.WriteLine();

    /*int, long 자료형의 최소값과 최대값 MaxValue, MinValue 83p*/
    Console.WriteLine(int.MaxValue);
    Console.WriteLine(int.MinValue);
    Console.WriteLine(long.MaxValue);
    Console.WriteLine(long.MinValue);
    Console.WriteLine(uint.MaxValue);/*uint는 음수가 없어진형태 */
    Console.WriteLine(uint.MinValue);
    Console.WriteLine(ulong.MaxValue);
    Console.WriteLine(ulong.MinValue);
    Console.WriteLine();

    /*실수자료형 하기 84p pass*/
    Console.WriteLine();
    Console.WriteLine();


    /*문자자료형 char 85p*/
    char ch1 = 'A';
    Console.WriteLine(ch1);
    /*몇바이트인지 구하기 sizeof 85p*/
    Console.WriteLine("int" + sizeof(int));
    Console.WriteLine("long" + sizeof(long));
    Console.WriteLine("float" + sizeof(float));
    Console.WriteLine("double" + sizeof(double));
    Console.WriteLine("char" + sizeof(char));
    Console.WriteLine();

    /*문자가 나타내는 수 구하는 법 86p
     1. 1로곱한다 *1
     2. 정수로 만든다 (int)char (""이 들어가면 +는 필수다) */
    char ch3 = 'F';
    char ch4 = 'k';
    Console.WriteLine(ch3 * 1);
    Console.WriteLine(ch4 * 1);
    Console.WriteLine(ch3 + " : " + (int)ch3);
    Console.WriteLine(ch4 + " : " + (int)ch4);

    Console.WriteLine(ch3 + ch4);
    Console.WriteLine(ch3 - ch4);
    Console.WriteLine(ch3 * ch4);
    Console.WriteLine(ch3 / ch4);
    Console.WriteLine(ch3 % ch4);
    Console.WriteLine();

    /*문자열 자료형 message 87p*/
    string message = "안녕하세요";/*string는 문자열 자료형 */
    Console.WriteLine(message+"!");
    Console.WriteLine(message[0]);
    Console.WriteLine(message[1]);
    Console.WriteLine(message[3]);
    Console.WriteLine();

    /*불 자료형 bool 89p pass*/
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine("05 복합대입 연산자");
    /* 숫자에 적용하는 복합대입 연산자 90p
       += 덧셈후 대입
       -= 뺄셈후 대입
       *= 곱셈후 대입
       /= 나눗셈후 대입
     * 문자에 적용하는 복합대입 연산자
       += 문자 연결 후 대입*/
    int output = 0;
    output += 103;
    output *= 6;
    output = output - 103;/*다른 방식*/
    Console.WriteLine(output);

    string output1 = "hello";
    output1 += "world";
    output1 = output1 + "!";
    Console.WriteLine(output1);
    Console.WriteLine();

    Console.WriteLine("06 증감 연산자");
    /* 연산자    설명 93p
     * [변수]++ 기존 변수의 값에 1을 더한다(후위)
     * ++[변수] 기존 변수의 값에 1을 더한다(전위)
     * [변수]-- 기존 변수의 값에 1을 뺀다(후위)
     * --[변수] 기존 변수의 값에 1을 뺀다(전위)*/

    int number = 10;
    number++;
    Console.WriteLine(number);
    number--;
    Console.WriteLine(number);
    ++number;
    Console.WriteLine(number);
    --number;
    Console.WriteLine(number);/*한 줄에 독립적으로 사용할 때는 전위와 후위의 차이를 알 수 없다*/
    Console.WriteLine();

    int number1 = 10;/*94p*/
    Console.WriteLine("후위" + number1);
    Console.WriteLine(number1++);
    Console.WriteLine(number1--);
    Console.WriteLine(number1);
    Console.WriteLine("전위" + number1);
    Console.WriteLine(++number1);
    Console.WriteLine(--number1);
    Console.WriteLine(number1);
    Console.WriteLine();

    int number2 = 20;
    number2 += 5; Console.WriteLine(number2);/*=Console.WriteLine(++number2);*/
    Console.WriteLine(number2); number2 -= 5;/*=Console.WriteLine(number2--);*/
    Console.WriteLine(number2);
}

