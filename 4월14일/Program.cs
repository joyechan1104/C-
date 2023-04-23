using System;
using System.Collections.Generic;

namespace _4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생성할 개수: ");
            int size = int.Parse(Console.ReadLine());
            int[] intArray = new int[size];
            Console.WriteLine($"정수 {size}개 출력");
            Random r = new Random();
            for (int i = 0; i < size; i++) //i < size(변수) 또는 i < intArray.Length; 도 사용 가능
                intArray[i] = r.Next(100); //(100) = 0~99까지
            for (int i = 0; i < size; i++)
                Console.Write("{0,5}", intArray[i]);
            int max = intArray[0], min = intArray[0];
            for(int i = 1; i < size; i++)   //1부터 끝까지 비교
            {
                if (intArray[i] > max)
                    max = intArray[i];
                if (intArray[i] < min)
                    min = intArray[i];
            }
            Console.WriteLine("\n최대값 : {0}", max);
            Console.WriteLine("최소값 : {0}", min);

            //리스트 요소 추가
            List<int> list = new List<int>(); //<int> 없어도 되지만, 나중에 필요함, list 사용시 제네릭 참조 추가할 것
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "|titem:" + item); // 역슬래쉬 t는 탭으로 띄우는 것
            }

            /*Console.Write("생성할 개수: ");
            int size = int.Parse(Console.ReadLine());
            List<int> list = new List<int>() { size };

            Console.WriteLine($"정수 {size}개 출력");

            Random r = new Random();
            for (int i = 0; i < size; i++)
                list[i] = r.Next(20);

            for (int i = 0; i < size; i++)
                Console.Write("{0,5}", list[i]);*/

        }
    }
}