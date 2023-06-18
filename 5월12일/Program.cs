class program
{
    class Box
    {
        //변수의 속성
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }

        //생성자
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //인스턴트 메소드
        public int Area() { return this.width * this.height; }
    }

    static void Main(string[] args)
    {
        Box box = new Box(+10, -20);

        box.Width = -200;
        box.Height = +100;
        Console.WriteLine(box.Area());
    }
}