using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LayeredAttributeTests
{
    public Permanent permanent;

    [TestInitialize]
    public void InitializeLayeredAttributeTests()
    {
        permanent = new Permanent();
    }

    [TestMethod]
    public void MyTestMethod()
    {
        Assert.IsNotNull(permanent);
    }
}