using Recreate;
using System;
using System.Text;

class Program {
    public static void count(vm m)
    {
        int x, y, r;
        char s, c;
        Console.WriteLine("Введите х: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите s: ");
        s = Convert.ToChar(Console.ReadLine());

        r = m.realization(x, y, s);
        while (true)
        {
            Console.WriteLine("продолжить выполнения действий? 1-да,2-выход");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("продолжить выполнения действий? 1-да,2-выход");

            switch (c)
            {
                case '1':
                    Console.WriteLine(r);
                    y = Convert.ToInt32(Console.ReadLine());

                    s = Convert.ToChar(Console.ReadLine());

                    r = m.realization(r, y, s);
                    break;
                case '2': return;
            }
        }
    }
    public static void Menu(vm m)
    {
        char c, s;
        int i, k, x, y;
        int min, max;
        Console.WriteLine(" 0-выход");
        Console.WriteLine(" 1-Добавления ЦПУ1");
        Console.WriteLine(" 2-Добавления ЦПУ2");
        Console.WriteLine(" 3-Удаление ЦПУ1");
        Console.WriteLine(" 4-Удаление ЦПУ2");
        Console.WriteLine(" 5-вывод количества ЦПУ1");
        Console.WriteLine(" 6-вывод количества ЦПУ2");
        Console.WriteLine(" 7-Выполнить программу");

        c = Convert.ToChar(Console.ReadLine());

        int r;
        switch (c)
        {
            case '0': return;
            case '1':
                Cpu1 c1 = new Cpu1();
                Console.WriteLine("введите минимум и максимум");
                Console.WriteLine("min:");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("max:");
                max = Convert.ToInt32(Console.ReadLine());
                c1.setscop(min, max); m.addcpu1(c1); break;
            case '2':
                Cpu2 c2 = new Cpu2();
                Console.WriteLine("введите минимум и максимум");
                Console.WriteLine("min:");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("max:");
                max = Convert.ToInt32(Console.ReadLine());
                c2.setscop(min, max); m.addcpu2(c2); break;
            case '3':
                Console.WriteLine("номер элемента");
                i = Convert.ToInt32(Console.ReadLine());
                m.delcpu1(i); break;
            case '4':
                Console.WriteLine("номер элемента");
                i = Convert.ToInt32(Console.ReadLine());
                m.delcpu2(i); break;
            case '5': k = m.amount1(); Console.WriteLine(k); break;
            case '6': k = m.amount2(); Console.WriteLine(k); break;
            case '7': count(m); break;
        }
        Menu(m);
    }

}
