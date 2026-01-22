using Xunit;
using Slugify;

public class DetailTests
{
    [Fact]
    public void Slug_basic_example()
    {
        var sut = new Detail();

        var result = sut.Slug("\"Pulp Fiction\" von Quentin Tarantino");

        Assert.Equal("pulp-fiction-von-quentin-tarantino", result);
    }

    private readonly Detail _detail = new();

    [Theory]
    [InlineData("\"Pulp Fiction\" von Quentin Tarantino", "pulp-fiction-von-quentin-tarantino")]
    [InlineData("\"Die fabelhafte Welt der Amélie\" von Jean-Pierre Jeunet", "die-fabelhafte-welt-der-amelie-von-jean-pierre-jeunet")]
    [InlineData("\"Fack ju Göhte\" von Bora Dağtekin", "fack-ju-goehte-von-bora-dagtekin")]
    [InlineData("\"Unrockbar\" von Die Ärzte", "unrockbar-von-die-aerzte")]
    [InlineData("\"Der Augenjäger\" von Sebastian Fitzek", "der-augenjaeger-von-sebastian-fitzek")]
    public void Slugify_returns_expected_slug(string titleLine, string expectedSlug)
    {
        var result = _detail.Slug(titleLine);

        Assert.Equal(expectedSlug, result);
    }
}
