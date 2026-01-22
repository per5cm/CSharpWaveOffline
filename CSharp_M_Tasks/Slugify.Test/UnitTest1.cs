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
}
