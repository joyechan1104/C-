using System.Numerics;

class program
{
    class Test
    {
        public int Multiply(int min , int max)
        {
            string a = "*";
            string output = a;
            for (int i = min; i <= max; i++) 
            {
                output *= i;
                for (int j = min; j <= max; j++) ;
                    Console.Write(a);
                Console.WriteLine("/n");

            }
            return output;
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multiply(1,5));

        }
    }
}