
namespace ImcCalculator.Tests;
[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldCalculateIMC()
    {
        var imc = Calculator.CalculateIMC(1.80,66.0);
        var imcWaited = (20.37, "Peso normal",0);
        Assert.AreEqual(imcWaited,imc);
    }
}