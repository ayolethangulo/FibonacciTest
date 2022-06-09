using NUnit.Framework;

namespace FibonacciTest
{
    public class PruebaFibonacciTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PrimeraPosicionCero()
        {
            var respuesta = sumarPosicion(1);
            Assert.AreEqual(0,respuesta);
        }

        [Test]
        public void SegundaPosicionUno()
        {
            var respuesta = sumarPosicion(2);
            Assert.AreEqual(1, respuesta);
        }

        [Test]
        public void ValidarQueSeaMayorACero()
        {
            var respuesta = sumarPosicion(-5);
            Assert.AreEqual(-1, respuesta);
        }

        [Test]
        public void ValidarNPosicion()
        {
            var respuesta = sumarPosicion(3);
            Assert.AreEqual(1, respuesta);
        }

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
            }
            else
            {
                resultado = -1;
            }
            
            return resultado;
        }

    }
}