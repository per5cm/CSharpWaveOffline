using ClimateChange_ExE.Library;
using Xunit;

namespace ClimateChangeTest;

public class AcTests
{
    [Theory]
    [InlineData(16.5, Level.Light)]

    public void LevelControl_ReturnExpectedLevel(double currentSum, Level expectedLevel)
    {
        Ac machine = new(targetSum: 21.5, currentSum, outsideSum: 13, acActive: false);
        
        var result = machine.LevelControl();
        
        Assert.Equal(expectedLevel, result);
    }
    
    [Fact]
    public void AcActivation_WhenTargetGreaterThanCurrent()
    {
        // arrange - construct an AC 
        Ac machine = new(targetSum: 25.5, currentSum: 18.5, outsideSum: 18, acActive: false);
        
        // act - which method 
        var result = machine.AcActivation();
        
        // assert
        Assert.True(result);
        Assert.True(machine.AcActive);
    }

    [Fact]
    public void AcDeactivation_WhenTargetLessThanCurrent()
    {
        Ac machine = new(targetSum: 25.5, currentSum: 12.5, outsideSum: 19, acActive: true);

        var result = machine.AcActivation();
        
        Assert.False(result);
        Assert.False(machine.AcActive);
    }
}