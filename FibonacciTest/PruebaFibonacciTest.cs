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

        public int sumarPosicion(int posicion)
        {
            return 0;
        }
    }
}