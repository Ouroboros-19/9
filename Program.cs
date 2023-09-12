class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 10, k = 0, kk = 0;
        int[] array = new int[a];
        for (int i = 0; i < a; i++)
        {
            array[i] = r.Next(-3, 4);
            Console.Write("{0,3}", array[i]);
        }
        Console.WriteLine();
        for (int ii = 0; ii < a; ii++)
            if (array[0] == array[ii])
                k++;
        Console.WriteLine("{0,4} встречается {1} раз", array[0], k);
        for (int i = 1; i < a; i++)
        {
            kk = 0;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                    kk++;
            }
            if (kk == 0)
            {
                k = 0;
                for (int ii = 0; ii < a; ii++)
                    if (array[i] == array[ii])
                        k++;
                Console.WriteLine("{0,4} встречается {1} раз", array[i], k);
            }
        }
        Console.WriteLine();
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}