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
            var respuesta = sumarPosicion(8);
            Assert.AreEqual(13, respuesta);
        }

    }
}