
namespace ImcCalculator.Tests;
[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldCalculateIMC()
    {
        var imc = Calculator.CalculateIMC(1.80,66.0);
        var imcWaited = (20.37, "Peso normal");
        Assert.AreEqual(imcWaited,imc);
    }

}