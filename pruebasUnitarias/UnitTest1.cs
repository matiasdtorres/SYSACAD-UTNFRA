using biblioteca;

namespace pruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificoAdmin()
        {
            // Arrange
            string usuario = "matias";
            string contraseņa = "123";

            // Act
            bool resultado = VerificarDatos.VerificoAdmin(usuario, contraseņa);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEstudiantePagos()
        {
            // Arrange
            Estudiante estudiante = new Estudiante(1, "Matias", "Towers", "direccion", "123456789", "correo@m.com", "contraseņa");

            // Act
            int filasAfectadas = estudiante.EstudiantePagos();

            // Assert
            Assert.AreEqual(1, filasAfectadas);
        }

        [TestMethod]
        public void TestAgregarProfesor()
        {
            // Arrange
            Profesores profesor = new Profesores("profecapo", "Mauro", "Bustos", "123456789", "direccion", "correo@m.com", "contraseņa", "especializacion");

            // Act
            int filasAfectadas = profesor.AgregarRol();

            // Assert
            Assert.AreEqual(1, filasAfectadas);
        }
    }
}