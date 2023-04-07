// See https://aka.ms/new-console-template for more information

Console.WriteLine("");

/*write만있으면 그대로 출력writeLine이면 행변경해서 출력 */
Console.WriteLine("write");
Console.Write("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("");

/*표현식과 마지막에 세미클론(;)이 찍히면 문장이된다 */
Console.WriteLine("273");
Console.WriteLine("10+20+30*2");
Console.WriteLine("c#programing");
/*식별자 (이름을붙일떄 사용하는 단어) 규칙
 * 1.키워드 사용불가 break (no)
 * 2.특수문자 _ 만 허용 
 * 3.숫자로 시작 안됨 273alpha (no) 
 * 4.공백 입력 불가 has space (no) 
 * alpha, alpha10, _alpha, Alpha, ALPHA (yes) */

Console.WriteLine("iLoveYou");
Console.WriteLine("iAmBoy");
Console.WriteLine("createServer");
Console.WriteLine("");

/*정수 */
Console.WriteLine(52+273);
Console.WriteLine(5+3*2);
Console.WriteLine(863-1552);
Console.WriteLine(15*20);
Console.WriteLine(50/4);
Console.WriteLine(50%4);
/* 나머지의 연산자부호는 항상 앞쪽을 따른다 */
Console.WriteLine(167%-35);
Console.WriteLine(-167%35);
Console.WriteLine("");

/*실수 */
Console.WriteLine(25.788);
Console.WriteLine(1.0+3.0);
Console.WriteLine(7.0-4.5);
Console.WriteLine(1.5*2);
Console.WriteLine(1.0/2);
Console.WriteLine("");

/*문자: 하나의 글자양끝에 ' 를찍으면 된다 */
Console.WriteLine('라');
Console.WriteLine('a');
Console.WriteLine('가');
/*문자열: 문자의 집합 " 를 붙여서 사용한다 */
Console.WriteLine("안녕하세요");
/*이스케이프 문자 (특수기능수행)*/
Console.WriteLine("신라\t아카데미");
Console.WriteLine("신라\n아카데미");
Console.WriteLine("신라\\아카\"\"\"데미");
/*문자열 연결 연산자 (단 준자 ' + '는 연결이 안된다 */
Console.WriteLine("가나다"+"마바사아자"+"차카타파하");
Console.WriteLine('가'+'힝');/*연결 안됨 */
/*문자선택 컴퓨터는 시작번호가 0번이다 (문자수보다 많은 수를 입력하면 오류가 뜬다) */
Console.Write("안녕하세요"[0]);
Console.Write("안녕해세요"[2]);
Console.WriteLine("안녕하세요"[4]);
Console.WriteLine("");

/*불 */
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine(105<105);
Console.WriteLine(77>105);
Console.WriteLine(77==105);/*같다 */
Console.WriteLine(77!=105);/*다르다 */
Console.WriteLine(77<=105);
Console.WriteLine(105>=105);
