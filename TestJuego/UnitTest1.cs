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
            piedra.Tipo = "tijera";
            var result = piedra.Jugar(piedra);
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestPiedraEmpata()
        {
            var piedra = new Piedra();
            piedra.Tipo = "piedra";
            var result = piedra.Jugar(piedra);
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestPiedraPierde()
        {
            var piedra = new Piedra();
            piedra.Tipo = "papel";
            var result = piedra.Jugar(piedra);
            Assert.Equal("perdio", result);
        }


        /*test papel*/

        [Fact]
        public void TestPapelGano()
        {
            var papel = new Papel();
            papel.Tipo = "piedra";
            var result =papel.Jugar(papel);
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestPapelEmpata()
        {
            var papel = new Papel();
            papel.Tipo = "papel";
            var result =papel.Jugar(papel);
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestPapelPierde()
        {
            var papel = new Papel();
            papel.Tipo = "tijera";
            var result = papel.Jugar(papel);
            Assert.Equal("perdio", result);
        }


        /*test tijera*/

        [Fact]
        public void TestTijeraGano()
        {
            var tijera = new Tijera();
            tijera.Tipo = "papel";
            var result = tijera.Jugar(tijera);
            Assert.Equal("gano", result);
        }
        [Fact]
        public void TestTijeraEmpata()
        {
            var tijera = new Tijera();
            tijera.Tipo = "tijera";
            var result =tijera.Jugar(tijera);
            Assert.Equal("empato", result);
        }
        [Fact]
        public void TestTijeraPierde()
        {
            var tijera = new Tijera();
            tijera.Tipo = "piedra";
            var result = tijera.Jugar(tijera);
            Assert.Equal("perdio", result);
        }

    }
}