using System;
namespace Recreate
{
    class OverflowException : ArgumentException
    {
        public OverflowException(string message)
            : base(message)
        {
        }
    }
    public class operand
    {

        private int sum(int a, int b)
        {
            return a + b;
        }
        private int dif(int a, int b)
        {
            return a - b;
        }
        private int multi(int a, int b)
        {
            return a * b;
        }
        private int div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                
                if (b == 0)
                {
                    throw new DivideByZeroException("Недопустимо деление на 0");
                    
                }
                return 0;
            }
            
        }


        public int choice(int a, int b, char sign)
        {
            switch (sign)
            {
                case '+': return sum(a, b); break;
                case '-': return dif(a, b); break;
                case '*': return multi(a, b); break;
                case '/': return div(a, b); break;
                default: Console.WriteLine("неверный знак"); return 0;
            }
        }

    };
}
