using NUnit.Framework;
using FibonacciTDD;

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
            var fibonacci = new Fibonacci();
            var respuesta = fibonacci.sumarPosicion(1);
            Assert.AreEqual(0,respuesta);
        }

        [Test]
        public void SegundaPosicionUno()
        {
            var fibonacci = new Fibonacci();
            var respuesta = fibonacci.sumarPosicion(2);
            Assert.AreEqual(1, respuesta);
        }

        [Test]
        public void ValidarQueSeaMayorACero()
        {
            var fibonacci = new Fibonacci();
            var respuesta = fibonacci.sumarPosicion(-5);
            Assert.AreEqual(-1, respuesta);
        }

        [Test]
        public void ValidarNPosicion()
        {
            var fibonacci = new Fibonacci();
            var respuesta = fibonacci.sumarPosicion(8);
            Assert.AreEqual(13, respuesta);
        }

    }
}