using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5월15일;//이거 없으면 빨간줄 생기드라 

namespace _5월15일
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("수학성적입력 : ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("과학성적입력 : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("영어성적입력 : ");
            int e = int.Parse(Console.ReadLine());

            Grade grade = new Grade(m, s, e);
            Console.WriteLine("세 과목의 평균 : " + grade.average().ToString("0.00"));

            int a = int.Parse(Console.ReadLine());
        }
    }
}
