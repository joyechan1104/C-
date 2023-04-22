NewMethod();

static void NewMethod()
{
    Console.WriteLine();

    Random r = new Random();
    List<int> list = new List<int>();

    Console.WriteLine("랜덤하게 생성할 수 : ");
    int size = int.Parse(Console.ReadLine());

    for (int i = 0; i < size; i++)
        list.Add(r.Next(1, 21));

    for (int i = 0; i < size; i++)
        Console.WriteLine("삭제전 : ");
        Console.WriteLine("{0,3}", list[i]);

    //10보다 작은 리스트 요소 삭제 
    //for (int i = 0; i < list.Count; i++)
    //{
    //    if (list[i] < 10)
    //    {
    //        list.RemoveAt(i);
    //        i--;
    //    }


    list.RemoveAll(x => x < 10);

    for (int i = 0; i < list.Count; i++)
        Console.WriteLine("삭제후 : ");
        Console.WriteLine(" {0,3}", list[i]);


    Console.WriteLine();




}

