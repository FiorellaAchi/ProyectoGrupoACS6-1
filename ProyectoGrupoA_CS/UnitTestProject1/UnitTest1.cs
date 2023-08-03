using NUnit.Framework;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var result = controller.Index() as ViewResult;
            // Assert
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
