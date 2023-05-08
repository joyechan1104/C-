class program
{
    class MyMath
    {
        public static int Abs(int x)
        {
            if (x < 0)
                return -x; 
            else
                return x; 
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            Console.Write("양수변환 덧셈 = ");
            Console.WriteLine(MyMath.Add(MyMath.Abs(1),MyMath.Abs(-2)));
            Console.Write("그냥 덧셈 = ");
            Console.WriteLine(MyMath.Add(1, -2));
            Console.Write("그냥 덧셈 더블 = ");
            Console.WriteLine(MyMath.Add(1.5, 2.7));
        }
    }
}
