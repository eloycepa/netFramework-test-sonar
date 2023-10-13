using Microsoft.VisualStudio.TestTools.UnitTesting;
using netFramework_test_sonar.Controllers;
using System.Web.Mvc;

namespace netFramework_test_sonar.Test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestHomeView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestHomeAbout()
        {
            var controller = new HomeController();
            var result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewData["message"]);
        }

        [TestMethod]
        public void TestHomeContact()
        {
            var controller = new HomeController();
            var result = controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Your contact page.", result.ViewData["message"]);
        }
    }
}