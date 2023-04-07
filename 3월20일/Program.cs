internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("01. IF 조건문");//127p
        
        //if 뒤에는 세미클론을 붙이지 않는다
        //(입력받은 수 % 2) == 1 습관상 괄호 해주는 편이 좋다.

        //홀짝구분
        Console.Write("숫자입력(짝홀) : ");
        int input = int.Parse(Console.ReadLine());

        if ((input % 2) == 0)
        {
            Console.WriteLine("짝수입니다!");
        }
        if ((input % 2) == 1)
        {
            Console.WriteLine("홀수입니다!");
        }
        Console.WriteLine();

        //현재시간 구하기 129p
        Console.Write(DateTime.Now.Year + "년");
        Console.Write(DateTime.Now.Month + "월");
        Console.WriteLine(DateTime.Now.Day + "일");
        Console.Write(DateTime.Now.Hour + "시");
        Console.Write(DateTime.Now.Minute + "분");
        Console.WriteLine(DateTime.Now.Second + "초");

        //오전, 오후 구분 
        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine(" 오전입니다! ");
        }
        if (12 <= DateTime.Now.Hour)
            Console.WriteLine(" 오후입니다! ");

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("01. if else 조건문");//130p
        //홀짝구분2
        Console.Write("숫자입력(짝홀2) : ");
        int input1 = int.Parse(Console.ReadLine());

        if ((input1 % 2) == 0)
        {
            Console.WriteLine(" 짝수입니다! ");
        }
        else
        {
            Console.WriteLine(" 홀수입니다! ");
        }

        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전입니다.");
        }
        else
        {
            Console.WriteLine("오후입니다.");
        }
        Console.WriteLine();

        Console.WriteLine("03. 중첩 조건문");//132p


        if (DateTime.Now.Hour < 11)
        {
            Console.WriteLine("아침먹을시간입니다.");
        }
        else
        {
            if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심먹을시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁먹을시간입니다.");
            }
        }
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("문1 두개의 서로 다른 숫자를 입력받아 큰 수를 출력");
        //실행결과)
        //첫번째 숫자 입력 25
        //두번째 숫자 입력 32
        //두수중에 큰수는 32이고 작은수는 25이다.
        
        Console.Write("숫자입력 문1-1 : ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("숫자입력 문1-2 : ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine("두 수중에 큰수는" + number1 + "이고, 작은 수는" + number2 + "입니다");
        }
        else
        {
            Console.WriteLine("두 수중에 큰수는" + number2 + "이고, 작은 수는" + number1 + "입니다");
        }
        Console.WriteLine();


        Console.WriteLine("문2 입려된 수가 양수, 음수 인지를 판별");
        
        //실행결과)
        //숫자입력 -5
        //입력값 -5는 음수이다

        //숫자입력 0
        //입력값 0은 zero다

        //숫자입력 3
        //입력값 3은 양수이다*/

        Console.Write("숫자입력 문2 : ");
        int number3 = int.Parse(Console.ReadLine());

        if (number3 < 0)
        {
            Console.WriteLine("은(는) 음수입니다.");
        }
        else
        {
            if (number3 == 0)
            {
                Console.WriteLine("은(는) zero입니다.");
            }
            else
            {
                Console.WriteLine("은(는) 양수입니다.");
            }
        }
        Console.WriteLine();


        Console.WriteLine("문3 놀이공원 입장");
        Console.Write("나이 입력 문3 : ");
        int number4 = int.Parse(Console.ReadLine());

        if (number4 < 9)
        {
            Console.WriteLine("9세 미만의 어린이는 입장불가 입니다.");
        }

        Console.Write("키 입력 문3 : ");
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
 

        Console.WriteLine("문4 자리수 판별");
        Console.Write("정수 입력 문4 : ");
        int number6 = int.Parse(Console.ReadLine());

        if (number6 < 10)
        {
            Console.WriteLine("10~99사이의 정수만 입력하세요");
        }
        else
        {
            if (number6 > 99)
            {
                Console.WriteLine("10~99사이의 정수만 입력하세요");
            }
            else
            {
                if (number6 % 11 == 0)
                {
                    Console.WriteLine("Yes 10의자리와 1이자리가 같습니다!");
                }
                else
                {
                    if (!(number6 % 11 == 0))
                    {
                        Console.WriteLine("No 10의자리와 1의자리가 다릅니다!");
                    }
                }
            }
        }
        Console.WriteLine();

        /*

        Console.WriteLine("문5 중간크기의 수 출력");
        Console.Write("정수 입력1 문5 : ");
        double number7 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력2 문5 : ");
        double number8 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력3 문5 : ");
        double number9 = double.Parse(Console.ReadLine());

        Console.Write("정수 입력1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("정수 입력2 : ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("정수 입력3 : ");
        int num3 = int.Parse(Console.ReadLine());

        if ((num1 >= num2 && num1 <= num3) || (num1 <= num2 && num1 >= num3))
        {
            Console.WriteLine(num1);
        }
        else if ((num2 >= num1 && num2 <= num3) || (num2 <= num1 && num2 >= num3))
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine(num3);
        }

        */

        Console.WriteLine("문5 중간크기의 수 출력");
        Console.Write("정수 입력1 문5 : ");
        double number7 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력2 문5 : ");
        double number8 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력3 문5 : ");
        double number9 = double.Parse(Console.ReadLine());

        double mid = 0;
        if (number7 < number8)
        {
            if (number8 < number9)
            {
                mid = number8;
            }
            else
            {
                if (number7 < number9)
                {
                    mid = number9;
                }
                else
                {
                    mid = number7;
                }
            }
        }
        else
        {
            if (number7 < number9)
            {
                mid = number7;
            }
            else
            {
                if (number8 < number9)
                {
                    mid = number9;
                }
                else
                {
                    mid = number8;
                }
            }
        }
        Console.WriteLine("중간값은" + mid + "입니다.");

        Console.Write("정수 입력? 문? : ");
        double number10 = double.Parse(Console.ReadLine());

    }
}