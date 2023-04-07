internal class Program/*왼쪽의 드라이버 마우스 우클릭 누르고 3번줄에 있는걸로 */
{
    private static void Main(string[] args)
    {
        int a = -2147483648;/*최소값 */
        int b = -1;

        Console.WriteLine(a + b);
        /*최저치에서 오버플로우 해서 최대치가 된다 */

        int input_num1 = int.MinValue;
        int input_num2 = -1;

        Console.WriteLine(input_num1 + input_num2);
        Console.WriteLine("maxvalue:" + int.MaxValue);

        char ch1 = 'A';/*알파벳을 바꾸면 다른 수가 출력된다 */
        char ch2 = 'Q';

        /*알파벳 값을 알아낼 수 있는 방법 */
        Console.WriteLine(ch1+" : "+ch1*1);/*1로 곱하기 */
        Console.WriteLine(ch2+" : "+(int)ch2);/*정수로 바꾸기 */
        Console.WriteLine(ch1 + ch2);
        Console.WriteLine(ch1 - ch2);
        Console.WriteLine(ch1 * ch2);
        Console.WriteLine(ch1 / ch2);
        Console.WriteLine(ch1 % ch2);

        Console.WriteLine(ch1+ch2/2-8);
        Console.WriteLine(ch1 + ch2 / 2+8);

        Console.WriteLine(ch2 + " : " + (char)ch2);
    }
}