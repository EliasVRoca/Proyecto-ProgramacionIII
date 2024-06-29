using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___Programacion_III___UPC
{
    internal class Series
    {
        public int Serie_1(int numero)
        {
            int i = 2;
            int a = 0;
            int b = 1;
            int c = 0;
            if (numero == 2)
            {
                return b;
            }
            else if (numero == 3)
            {
                return b;
            }
            else
            {
                while (i < numero)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    i++;
                }
                return c;
            }
        }
        public int Serie_2(int numero)
        {
            int i = 0;
            int a = 0;
            while (i < numero)
            {
                if (a % 2 == 0)
                {
                    a = a + 1;
                }
                else
                {
                    a = a * 2;
                }
                i++;
            }
            return a;
        }
        public int Serie_3(int numero)
        {
            int i = 1;
            int a = 0;
            int b = 0;
            while (i < numero)
            {
                a = a + 2;
                b = b + a;
                i++;
            }
            return b;
        }
        public int Serie_4(int numero)
        {
            int i = 1;
            int a = 1;
            int b = 1;
            while (i < numero)

            {
                a = a * 2;
                b = b + a;
                i++;
            }
            return b;
        }
        public int Serie_5(int numero)
        {
            int i = 0;
            int a = 0;
            int b = 1;
            int c = 0;
            while (i < numero)
            {
                if (b == 1)
                {
                    a = a + 1;
                    b = 2;
                }
                else if (b == 2)
                {
                    a = a * 2;
                    b = 3;
                }
                else if (b == 3)
                {
                    a = a + 2;
                    b = 1;
                }
                if (a % 2 == 0)
                {
                    c = c + a;
                }
                i++;
            }
            return c;
        }
    }
}
