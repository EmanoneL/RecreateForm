using System;
using System.Collections.Generic;

namespace Recreate
{
    public class vm
    {
        List<Cpu1> arrcpu1 = new List<Cpu1>();
        List<Cpu2> arrcpu2 = new List<Cpu2>();

        public List<Cpu1> Arrcpu1
        {
            get { return arrcpu1; }
            protected set { arrcpu1 = value; }
        }
        public List<Cpu2> Arrcpu2
        {
            get { return arrcpu2; }
            protected set { arrcpu2 = value; }
        }

        public void addcpu1(Cpu1 c1)
        {
            arrcpu1.Add(c1);
        }
        public void addcpu2(Cpu2 c2)
        {
            arrcpu2.Add(c2);
        }
        public void delcpu1(int i)
        {

                for (int k = i; k < arrcpu1.Count - 1; k++)
                {
                    arrcpu1[k] = arrcpu1[k++];
                }
                //auto iter = arrcpu1.cbegin();
                arrcpu1.RemoveAt(i);


        }
        public void delcpu2(int i)
        {

                for (int k = i; k < arrcpu2.Count - 1; k++)
                {
                    arrcpu2[k] = arrcpu2[k++];
                }
                //auto iter = arrcpu1.cbegin();
                arrcpu2.RemoveAt(i);
        }


        public int amount1()
        {
            return arrcpu1.Count;
        }
        public int amount2()
        {
            return arrcpu2.Count;

        }
        public int realization(int x, int y, char s)
        {
            int r = 0;
            int des = 0;
            Random rand = new Random();

                if (arrcpu1.Count == 0) des = 2;
                if (arrcpu2.Count == 0) des = 1;
                if (!(arrcpu1.Count == 0) && !(arrcpu2.Count == 0)) des = rand.Next(1, 3);
                switch (des)
                {
                    case 1: if (arrcpu1.Count == 1) r = arrcpu1[0].act(x, y, s); else r = arrcpu1[rand.Next(0, arrcpu1.Count + 1)].act(x, y, s); break;
                    case 2: if (arrcpu2.Count == 1) r = arrcpu2[0].act2(x, y, s); else r = arrcpu2[rand.Next(0, arrcpu2.Count + 1)].act2(x, y, s); break;
                }
            return r;

        }
    }
}
