using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Negocio.EntitiesDTO.LibrosDTO libroEjemplo = new Negocio.EntitiesDTO.LibrosDTO();
                libroEjemplo.Nombre = "Prueba";
                libroEjemplo.Autor = "Ejemplo";
                libroEjemplo.FechaPublicacion = DateTime.Now;
                libroEjemplo.idCategoria = 2;

                new Negocio.Management.LibroManagement().AltaLibro(libroEjemplo);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "EL ALTA HA SIDO INCORRECTA");
                throw;
            }
        }
    }
}