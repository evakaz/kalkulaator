using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalkulaator_console;

namespace kalkulaator_test2
{
    [TestClass]
    public class UnitTestKalkulaator
    {
        [TestMethod]
        public void TestKalkulaatorLiita()
        {
            Assert.AreEqual(5, Calculator.calc2("+", 2, 3));
            Assert.AreEqual(-1, Calculator.calc2("+", 5, -6));
        }

        [TestMethod]
        public void TestKalkulaatorLahuta()
        {
            Assert.AreEqual(-1, Calculator.calc2("-", 2, 3));
        }

        [TestMethod]
        public void TestKalkulaatorJaaga()
        {
            Assert.AreEqual(0.5, Calculator.calc2("/", 4, 8));
            Assert.AreNotEqual(0.5, Calculator.calc2("/", 4, 10));
            Assert.IsTrue(Calculator.calc2("/", 4, 8) == 0.5);
            Assert.IsNotNull(Calculator.calc2("/", 4, 8));

            Assert.IsTrue(Calculator.calc2("/", 4, 8) < 1);

            Assert.AreEqual("4", Calculator.convertFromInt(4));
        }

        [TestMethod]
        public void TestNoException()
        {
            try
            {
                Calculator.nothing(1);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
