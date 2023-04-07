using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("04. if else if 조건문");//134p
        Console.WriteLine(90/10);

        if (DateTime.Now.Hour < 11)
            Console.WriteLine("아침먹을 시간입니다.");
        else if (DateTime.Now.Hour < 15)
            Console.WriteLine("점심먹을 시간입니다.");
        else
            Console.WriteLine("저녁먹을 시간입니다.");
        Console.WriteLine();


        Console.WriteLine("논리 연산자 조건문");//학점 135p
        Console.Write("학점입력 : ");
        double score = double.Parse(Console.ReadLine());

        if (score == 4.5)
            Console.WriteLine("신");
        else if (score >= 4.2)
            Console.WriteLine("교수님의 사랑");
        else if (score >= 3.5)
            Console.WriteLine("현체제의 수호자");
        else if (score >= 2.8)
            Console.WriteLine("일반인");
        else if (score >= 2.3)
            Console.WriteLine("일탈을 꿈꾸는소시민");
        else if (score >= 1.74)
            Console.WriteLine("오락문화의 선구자");
        else if (score >= 1.0)
            Console.WriteLine("불가축천민");
        else if (score >= 0.5)
            Console.WriteLine("자벌레");
        else if (score > 0.0)
            Console.WriteLine("플랑크톤");
        else if (score == 0.0)
            Console.WriteLine("are you human?");
        Console.WriteLine();


        Console.WriteLine("05.switch 조건문");//138p
        Console.Write("월입력 : ");
        double month = double.Parse(Console.ReadLine());
        switch (month)
        {
            case 12: case 1: case 2:
                Console.WriteLine("겨울입니다");
                break;
            case 3: case 4: case 5:
                Console.WriteLine("봄입니다");
                break;
            case 6: case 7: case 8:
                Console.WriteLine("여름입니다");
                break;
            case 9: case 10: case 11:
                Console.WriteLine("가을입니다");
                break;
            default:
                Console.WriteLine("지구가 아닙니다");
                break;
        }
        Console.WriteLine();


        Console.WriteLine("06. 삼항 연산자");//142p
        int sam = int.Parse(Console.ReadLine());
        Console.WriteLine(sam > 0 ? "자연수입니다" : "자연수가아닙니다");
        Console.WriteLine();



        Console.WriteLine("07. 함께하는 응용예제");//144p
        Console.WriteLine("키 입력 구분");//147p

        Console.WriteLine("방향키를 입력해 주세요");
        ConsoleKeyInfo info = Console.ReadKey();
        switch (info.Key) {
            case ConsoleKey.UpArrow:
                Console.WriteLine("위로 이동");
                break;
            case ConsoleKey.RightArrow:
                Console.WriteLine("오른쪽으로 이동");
                break;
            case ConsoleKey.LeftArrow:
                Console.WriteLine("왼쪽으로 이동");
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine("아래 로이동");
                break;
            default:
                Console.WriteLine("다른 키를 눌렀습니다");
                break;
        }
        Console.WriteLine();

        Console.WriteLine("문1. 자리수 판별");//if-elsa if로 바꾸기
        Console.Write("정수 입력 : ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10)
            Console.WriteLine("10~99사이의 정수만 입력하세요");
        else if (number > 99)
            Console.WriteLine("10~99사이의 정수만 입력하세요");
        else if (number % 11 == 0)
             Console.WriteLine("Yes 10의자리와 1이자리가 같습니다!");
        else if (!(number % 11 == 0))
             Console.WriteLine("No 10의자리와 1의자리가 다릅니다!");

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("문2. 중간크기의 수 출력");//if-elsa if로 바꾸기

        Console.Write("정수 입력1 : ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력2 : ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("정수 입력3 : ");
        double number3 = double.Parse(Console.ReadLine());

        double mid = 0;
        if (number1 < number2 && number2 < number3)
            mid = number2;
        else if (number3 < number2 && number2 < number1)
            mid = number2;
        else if (number2 < number1 && number1 < number3)
            mid = number1;
        else if (number3 < number1 && number1 < number2)
            mid = number1;
        else if (number1 < number3 && number3 < number2)
            mid = number3;
        else if (number2 < number3 && number3 < number1)
            mid = number3;

        Console.WriteLine("중간값은" + mid + "입니다.");
        Console.WriteLine();
        Console.WriteLine();*/


        Console.WriteLine("문3. if-else if 프로그램");
        Console.Write("성적 입력A : ");
        int scoreA = int.Parse(Console.ReadLine());
        Console.Write("성적 입력B : ");
        int scoreB = int.Parse(Console.ReadLine());

        if (scoreA + scoreB >=90)
            Console.Write("A학점");
        else if (scoreA + scoreB >= 80)
            Console.Write("B학점");
        else if (scoreA + scoreB >= 70)
            Console.Write("C학점");
        else if (scoreA + scoreB >= 60)
            Console.Write("D학점");
        else if (scoreA + scoreB < 60)
            Console.Write("재수강입니다 분발하세요");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("문4. 3번문제를 switch-case로");
        Console.Write("점수 입력C : ");
        int scoreC = int.Parse(Console.ReadLine());
        switch (scoreC / 10)
        {
            case 10: case 9: // case >= 90 (c#이랑 ft만 가능 권장안함)
                Console.WriteLine("A학점");
                break;
            case 8: // case >= 80
                Console.WriteLine("B학점");
                break;
            case 7: // case >= 70
                Console.WriteLine("C학점");
                break;
            case 6: // case >= 60
                Console.WriteLine("D학점");
                break;
            default: // case < 60
                Console.WriteLine("FFFFF");
                break;
        }
        Console.WriteLine();
        Console.WriteLine();




        /*Console.WriteLine("계산기 만들기 if-else if");
        Console.Write("정수입력1 : ");
        int numa = int.Parse(Console.ReadLine());
        Console.Write("연산자 입력 : ");
        string cal1 = (Console.ReadLine());
        Console.Write("정수입력2 : ");
        int numb = int.Parse(Console.ReadLine());

        if (cal1 == "+")
        Console.WriteLine($"{numa} + {numb} = {numa + numb}");
        else if (cal1 == "-")
            Console.WriteLine($"{numa} - {numb} = {numa - numb}");
        else if (cal1 == "*")
            Console.WriteLine($"{numa} * {numb} = {numa * numb}");
        else if (cal1 == "/")
            Console.WriteLine($"{numa} / {numb} = {numa / numb}");
        else if()
            Console.WriteLine("오류");
        */



        Console.WriteLine("계산기 만들기 switch case");
        Console.WriteLine("숫자입력1 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("연산자 입력 : ");
        string cal = (Console.ReadLine());
        Console.WriteLine("숫자입력2 : ");
        int num2 = int.Parse(Console.ReadLine());
        int value;
        switch (cal)
        {
            case "+":
                value = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + value);
                break;
            case "-":
                value = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + value);
                break;
            case "*":
                value = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + value);
                break;
            case "/":
                value = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + value);
                break;
            default:
                Console.WriteLine("뭘 또 잘못 입력했노?");
                break;
        }



        


        //Console.Write("입력 : ");
        //int score = int.Parse(Console.ReadLine());

    }
}