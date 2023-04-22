using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("07. 자료형 검사");
        //GetType: 해당변수의 자료형을 추출
        int _int = 273;
        long _long = 52273;
        float _flout = 52.273F;
        double _double = 52.273;
        char _char = '글';
        string _string = "문자열";

        Console.WriteLine(_int.GetType());
        Console.WriteLine(_long.GetType());
        Console.WriteLine(_flout.GetType());
        Console.WriteLine(_double.GetType());
        Console.WriteLine(_char.GetType());
        Console.WriteLine(_string.GetType());
        Console.WriteLine();

        Console.WriteLine("08. var 키워드");
        //var 자료형을 자동으로 지정 100p
        var number = 100; //int 자료형으로 지정
        var numberA = 100L; //long 자료형으로 지정
        var numberB = 100.0; //double 자료형으로 지정
        var numberC = 100F; //float 자료형으로 지정
        Console.WriteLine(123456 + 65432L); // l을 소문자 사용시 주의
        Console.WriteLine();

        Console.WriteLine("09. 입력");
        // Console.ReadLine(); 사용자로부터 한 줄의 문자열을 입력 받는다. 104p
        string input = Console.ReadLine();
        Console.WriteLine("input: " + input);
        Console.WriteLine();//Console.ReadLine();메서드는 문자열만 가능 숫자로 바꿀려면 다른방법 필요

        Console.WriteLine("10. 자료형 변환");// 106p
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber; //자동으로 변환불가 오류발생, 강제변환 (int)필요 
        Console.WriteLine(intNumber);//큰자료형을 작은자료형으로 바꿀시 숫자손상발생

        var a = (int)10.0;//강제 자료형 변환 107p
        Console.WriteLine(a);

        double doublenumber = 52.27310332;
        int doubleToInt = (int)doublenumber;
        Console.WriteLine(doublenumber);
        Console.WriteLine(doubleToInt);//int가되어 숫자가 깨진다
        Console.WriteLine();


        int intnumber1 = 2147483647; //자동 자료형 변환 109p
        long intToLong1 = intnumber1;
        Console.WriteLine(intToLong1);
        double intToDouble1 = intnumber1;
        Console.WriteLine(intToDouble1);
        Console.WriteLine();

        //문자열을 숫자로 변환 111p
        // 문자열을 숫자로 변환하는 메서드
        // int.parse() 다른자료형을 int자료형으로 변환
        // long.parse() 다른자료형을 long자료형으로 변환
        // float.parse() 다른자료형을 float자료형으로 변환
        // double.parse() 다른자료형을 double자료형으로 변환
        Console.WriteLine(int.Parse("52"));
        Console.WriteLine(long.Parse("273"));
        Console.WriteLine(float.Parse("52.273"));
        Console.WriteLine(double.Parse("103.32"));

        Console.WriteLine(int.Parse("52").GetType());
        Console.WriteLine(long.Parse("273").GetType());
        Console.WriteLine(float.Parse("52.273").GetType());
        Console.WriteLine(double.Parse("103.32").GetType());
        Console.WriteLine();

        //다른 자료형을 문자열로 변환 ToString 112p
        Console.WriteLine((52).ToString());
        Console.WriteLine((273).ToString());
        Console.WriteLine(('a').ToString());
        Console.WriteLine((true).ToString());
        Console.WriteLine((false).ToString());

        Console.WriteLine((52).ToString().GetType());
        Console.WriteLine((273).ToString().GetType());
        Console.WriteLine(('a').ToString().GetType());
        Console.WriteLine((true).ToString().GetType());
        Console.WriteLine((false).ToString().GetType());
        Console.WriteLine();

        //소수점제거 ToString("0.00") 114p
        double number2 = 52.273103;
        Console.WriteLine(number2.ToString("0"));
        Console.WriteLine(number2.ToString("0.0"));
        Console.WriteLine(number2.ToString("0.00"));
        Console.WriteLine(number2.ToString("0.000"));
        Console.WriteLine();

        //숫자와 문자열 덧셈 pass 114p

        //문자열을 불로 변환 pass 115p

        Console.WriteLine("문1 inch단위를 cm단위로 변환 1inch=2.54cm");

        Console.Write("inch입력 : ");
        string sinput = Console.ReadLine();
        int ninput = int.Parse(sinput);
        Console.WriteLine(ninput * 2.54 + "cm");
        Console.WriteLine();

        Console.WriteLine("문2 사칙연산 나눗셈은 소수점 둘째까지");
        /*string num1 = Console.ReadLine();
        int num3 = int.Parse(num1);
        string num2 = Console.ReadLine();
        int num4 = int.Parse(num2);*/

        Console.Write("정수입력1 : ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("정수입력2 : ");
        double num2 = double.Parse(Console.ReadLine());
        double num3 = num1 / num2;

        Console.WriteLine("덧셈 : " + num1 + num2);
        Console.Write("뺄셈 : ");
        Console.WriteLine(num1 - num2);
        Console.WriteLine("곱셈 : " + num1 * num2);
        Console.WriteLine("나눗셈 : " + num3.ToString("0.00"));

        Console.WriteLine();
        Console.WriteLine();

        /*
                int A = 2;
                int B = 3;

                double C = (double)A;
                double D = (double)B;
                double E = C / D;

                Console.WriteLine(C + D);
                Console.WriteLine(C - D);
                Console.WriteLine(C * D);
                Console.WriteLine(E.ToString("0.00"));
                Console.WriteLine();
        */

        Console.WriteLine("문3 원의공식 반지름 값을 입력받아 둘에와 넓이 구하기 /상수 대문자 사용 ");
        /* 둘레 = 2 * PI * 반지름 
         * 넓이 = PI * 반지름 * 반지름
         * PI = 3.14159 (상수로 정의함)
         * 둘레와 넓이모두 소수점 3자리까지 반올림하여 구하기 */

        Console.Write("반지름 입력 : ");
        string Radius = Console.ReadLine();
        double Radius1 = double.Parse(Radius);
        double PI = 3.14159;
        double Circumference = (double)2 * PI * Radius1;
        double Area = (double)PI * Radius1 * Radius1;
        //Console.WriteLine("둘레 = " + 2 * PI * Radius1);
        //Console.WriteLine("넓이 = " + PI * Radius1 * Radius1);
        Console.WriteLine("둘레 = " + Circumference.ToString("0.000"));
        Console.WriteLine("넓이 = " + Area.ToString("0.000"));
        Console.WriteLine();

        Console.WriteLine("문4 문자계산프로그램");
        /*콘솔 창에서 한 문자를 입력 받아 정수 5를 더한후 값을 출력하되 아래 실행 결과처럼 출력!
         * Console.Read() 사용, Convert.ToChar()
         
         * 실행 결과 예)
         * 문자 입력: A
           1. 연산 수행 전
            - 아스키코드 값 : 65
            - 변화된 문자 출력 : A
           2. 연산 수행 후
            - 아스키코드 값 : 70
            - 변화된 문자 출력 : F */

        Console.Write("문자입력 : ");
        int ch1 = Console.Read();
        Console.WriteLine("1.연산수행전 : ");
        Console.WriteLine("아스키코드 값 : " + ch1);
        Console.WriteLine("변환된 문자 출력 : " + Convert.ToChar(ch1));

        Console.WriteLine("2.연산수행후 : ");
        Console.WriteLine("아스키코드 값 : " + (ch1 + 5));
        Console.WriteLine("변환된 문자 출력 : " + Convert.ToChar(ch1 + 5));




    }
}