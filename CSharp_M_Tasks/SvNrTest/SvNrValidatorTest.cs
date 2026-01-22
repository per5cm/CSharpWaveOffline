using SvNr;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace SvNrTest
{
    public class SvNrValidatorTest
    {
        [Fact]
        public void Valid_Format_Passes()
        {
            Assert.True(SvNrValidator.IsValidFormat("12 150485 M 003"));
            Assert.True(SvNrValidator.IsValidFormat("01 010101 F 123"));
            Assert.True(SvNrValidator.IsValidFormat("  12   150485   m   003  "));
        }

        [Fact]
        public void Invalid_Format_Fails()
        {
            Assert.False(SvNrValidator.IsValidFormat("12-150485-M-003"));
            Assert.False(SvNrValidator.IsValidFormat("12150485M003"));
            Assert.False(SvNrValidator.IsValidFormat("01 010101 1 123"));
            Assert.False(SvNrValidator.IsValidFormat("     "));
        }
    }
}
