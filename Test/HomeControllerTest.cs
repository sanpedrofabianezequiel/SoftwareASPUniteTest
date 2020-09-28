using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;
namespace Test
{
    //Agregamos el USING para acceder a todos los MVC - MODELOS - CONTROLLER de la PAGE principal
    //System.Web.Mvc;
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_Index_Return_View()
        {
            //Usamos las clases referenciadas
            //RENOMBRAMOS EL METODO por convencion
            //Creo una instancia de mi Home controller de la Page
            HomeController controller = new HomeController();

            //invocamos  su metodo INDEX de la clase HomeController
            //Para ver ese resultado de ese RETUNRN o VIEWRESULT;
            var result = controller.Index() as ViewResult;

            //ASSERT nos sirve para realizar las pruebas
            //( string esperado,a comparar)
            //ACA estamos comparando el nombre de la vista
            //result.ViewName => Nombre de la vista
            
            Assert.AreEqual("Index",result.ViewName);

        }
    }
}
