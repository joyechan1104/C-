using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5월15일_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("수학성적입력 : ");
            int m = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("과학성적입력 : ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("영어성적입력 : ");
            int e = int.Parse(Console.ReadLine());

            Grade grade = new Grade(m, s, e);
            Console.WriteLine("세 과목의 평균 : " + grade.average());

            int a = int.Parse(Console.ReadLine());


        }
    }
}
