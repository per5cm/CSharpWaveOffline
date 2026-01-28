using SvNr_2;

namespace SvNr_2Test
{
    public class SVNummernTest
    {
        [Fact]
        public void IstGueltig_SVNummer_Result_True()
        {
            SV sV = new();
            var result = sV.IstGueltig("65160684M007");
            Assert.True(result);
        }

        [Fact]
        public void IstGueltig_SVNummer_Result_False()
        {
            SV sV = new();
            var result = sV.IstGueltig("990203A123456");
            Assert.False(result);
        }

        [Fact]
        public void IstGueltig_SVGebDatum_Result_True()
        {
            SV sV = new();
            var result = sV.IstGueltig("65170806J008");
            Assert.True(result);
        }

        [Fact]
        public void IstGueltig_SVGebDatum_Result_False()
        {
            SV sV = new();
            var result = sV.IstGueltig("65171306J008");
            Assert.False(result);
        }

        [Fact]
        public void IstGueltig_Zahl_Statt_Buchstabe_Result_False()
        {
            SV sV = new();
            var result = sV.IstGueltig("651713066008");
            Assert.False(result);
        }
    }
}
