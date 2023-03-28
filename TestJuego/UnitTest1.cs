using JuegoPiedraPapelTijera;

namespace TestJuego
{
    public class UnitTest1
    {
        /*test piedra*/
        
        [Fact]
        public void TestPiedraGano()
        {
            var piedra = new Piedra();
            var result = piedra.Jugar("tijera");
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestPiedraEmpata()
        {
            var piedra = new Piedra();
            var result = piedra.Jugar("piedra");
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestPiedraPierde()
        {
            var piedra = new Piedra();
            var result = piedra.Jugar("papel");
            Assert.Equal("perdio", result);
        }


        /*test papel*/

        [Fact]
        public void TestPapelGano()
        {
            var papel = new Papel();
            var result =papel.Jugar("piedra");
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestPapelEmpata()
        {
            var papel = new Papel();
            var result =papel.Jugar("papel");
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestPapelPierde()
        {
            var papel = new Papel();
            var result = papel.Jugar("tijera");
            Assert.Equal("perdio", result);
        }


        /*test tijera*/

        [Fact]
        public void TestTijeraGano()
        {
            var tijera = new Tijera();
            var result = tijera.Jugar("papel");
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestTijeraEmpata()
        {
            var tijera = new Tijera();
            var result =tijera.Jugar("tijera");
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestTijeraPierde()
        {
            var tijera = new Tijera();
            var result = tijera.Jugar("piedra");
            Assert.Equal("perdio", result);
        }

    }
}