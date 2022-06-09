using System;

namespace FibonacciTDD
{
    public class Fibonacci
    {
        public int sumarPosicion(int posicion)
        {
            int resultado = 0;
            if (posicion >= 0)
            {
                if (posicion.Equals(1))
                {
                    resultado = 0;
                }
                else if (posicion.Equals(2))
                {
                    resultado = 1;
                }
                else
                {
                    //validar n posicion
                    int a = 0; int b = 1; int c = 0;
                    for (int i = 1; i < posicion; i++)
                    {
                        a = b;
                        b = c;
                        c = a + b;
                    }
                    resultado = c;
                }
            }
            else
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
