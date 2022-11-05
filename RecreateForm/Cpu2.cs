using System;


namespace Recreate
{
    public class Cpu2 : operand
{
    int res;
    int min;
    int max;
    int spec;
        public int Res
        {
            get { return res; }
            protected set { res = value; }
        }
        public int Min
        {
            get { return min; }
            protected set { min = value; }
        }
        public int Spec
        {
            get { return spec; }
            protected set { spec = value; }
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



        private int overflow(int res)
    {
        spec = -1;
        if ((res > max) || (res < min) || (res == spec))
        {
            throw new OverflowException("Переполнение");
        }
        return res;
    }
    public Cpu2()
    {
        min = 0;
        max = 100;
        res = 0;
        spec = -1;
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
    }
    public int act2(int x, int y, char s)
    {
        res = choice(x, y, s);
        res = overflow(res);
        return res;
    }

};

}
