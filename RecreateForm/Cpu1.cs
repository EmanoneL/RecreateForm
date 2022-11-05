using System;


namespace Recreate
{


    public class Cpu1 : operand{
    int res;
    int max;
    int min;

        public int Res
        {
            get { return res; }
            set { res = value; }
        }
        public int Min
        {
            get { return min; }
            protected set { min = value; }
        }
        public int Max
        {
            get { return max; }
            protected set
            {
                if (value <= min)
                {
                    int k = min;
                    max = k;
                    min = max;
                    
                }
                else max = value;
            }
        }
        private int overflow(int res, int a, int b)
    {
        if ((res > max) || (res < min))
        {
            throw new OverflowException("Переполнение");
        }
        return res;
    }
    public Cpu1()
    {
        min = 0;
        max = 100;
        res = 0;
    }
    public void setscop(int min_x, int max_x)
    {
            if (min_x > max_x)
            {
                int k = min_x;
                max_x = k;
                min_x = max_x;
            }
            min = min_x;
        max = max_x;
        res = 0;
    }
    public int act(int x, int y, char s)
    {
        res = choice(x, y, s);
        res = overflow(res, x, y);
        return res;
    }
};

}
