using System;

namespace FibonacciTDD
{
    public class Fibonacci
    {
        public int sumarPosicion(int posicion)
        {
            switch (posicion)
            {
                case 1:
                    return 0;
                case 2:
                    return 1;
                case < 0:
                    return -1;
                default:
                    return NPosicion(posicion);
            }
        }
        public int NPosicion(int posicion)
        {
            //validar n posicion
            int a = 0; int b = 1; int c = 0;
            for (int i = 1; i < posicion; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }
    }
}
