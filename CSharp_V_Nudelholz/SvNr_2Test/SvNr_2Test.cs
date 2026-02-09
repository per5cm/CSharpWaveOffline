using SvNr_2;

using System;

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
    public void IstGueltig_ZahlstattBuchstabe_Result_False()
    {
        SV sV = new();
        var result = sV.IstGueltig("651713068008");
        Assert.False(result);
    }

    [Fact]
    public void BuchstabeZuZahl_EingabeA_Result_1()
    {
        SV sV = new();
        var result = sV.BuchstabeZuZahl('A');
        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData('A', 1)]
    [InlineData('B', 2)]
    [InlineData('C', 3)]
    public void BuchstabeZuZahl_VerschiedeneEingaben_Result(char eingabe, int erwartetesErgebnis)
    {
        SV sV = new();
        var result = sV.BuchstabeZuZahl(eingabe);
        Assert.Equal(erwartetesErgebnis, result);
    }

    [Fact]
    public void MultiplikationFaktoren_EingabeSVNummer_Result_IntArrayMitKorrekterFaktorenberechnung()
    {
        // Vorbereitung des Tests
        SV sV = new();

        // arrange-Schritt aufrufen und ausfÃ¼hren der Methode (Was ich habe und was ich brauche)
        string input = "65170806J008";
        int[] erwartetesErgebnis = { 2 * 6, 1 * 5, 2 * 1, 5 * 7, 7 * 0, 1 * 8, 2 * 0, 1 * 6, 2 * 10, 1 * 0, 2 * 0, 1 * 8 };

        // act-Schritt 
        int[] result = sV.MultiplikationFaktoren(input); //Methode wird aufrufen
        Assert.Equal(erwartetesErgebnis, result);
    }

    [Fact]
    public void QuersummeBerechnen_GewichteteProdukte_Result_ArrayVonQuersumme()
    {
        // Arrange
        SV sV = new();
        int[] arrayVonGewichtetenProdukten = { 2 * 6, 1 * 5, 2 * 1, 5 * 7, 7 * 0, 1 * 8, 2 * 0, 1 * 6, 2 * 10, 1 * 0, 2 * 0, 1 * 8 };
        int[] erwartetesErgebnis = { 3, 5, 2, 8, 0, 8, 0, 6, 2, 0, 0, 8 };
        // Act
        var result = SV.QuersummeBerechnen(arrayVonGewichtetenProdukten);

        // Assert
        Assert.Equal(erwartetesErgebnis, result);
    }
}
