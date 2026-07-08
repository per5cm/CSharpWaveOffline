using ClimateChange_ExE.Library;
using Xunit;

namespace ClimateChangeTest;

public class AcTests
{
    [Theory]
    [InlineData(16.5, Level.Light)]

    public void LevelControl_ReturnExpectedLevel(double currentTemp, Level expectedLevel)
    {
        Ac machine = new(targetTemp: 21.5, currentTemp: currentTemp, acActive: false);
        
        var result = machine.LevelControl();
        
        Assert.Equal(expectedLevel, result);
    }
    
    [Fact]
    public void AcActivation_WhenTargetGreaterThanCurrent()
    {
        // arrange - construct an AC 
        Ac machine = new(targetTemp: 25.5, currentTemp: 18.5, acActive: false);
        
        // act - which method 
        var result = machine.AcActivation();
        
        // assert
        Assert.True(result);
        Assert.True(machine.AcActive);
    }

    [Fact]
    public void AcDeactivation_WhenTargetLessThanCurrent()
    {
        Ac machine = new(targetTemp: 25.5, currentTemp: 12.5, acActive: true);

        var result = machine.AcActivation();
        
        Assert.True(result);
        Assert.True(machine.AcActive);
    }

    [Fact]
    public void AcDeactivation_WhenTargetOff()
    {
        Ac machine = new(targetTemp: 25.5, currentTemp: 25.5, acActive: false);
        
        var result = machine.AcActivation();
        
        Assert.False(result);
        Assert.False(machine.AcActive);
    }
}