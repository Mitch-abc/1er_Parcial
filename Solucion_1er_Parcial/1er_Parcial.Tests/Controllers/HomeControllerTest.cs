using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1er_Parcial;
using _1er_Parcial.Controllers;

namespace _1er_Parcial.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
