using Compuertas_logicas;
namespace CompuertasTest;

public class NotTests
{
    private Not not1;

    [SetUp]
    public void Setup()
    {
        not1 = new Not("not", true);
    }

    [Test]
    public void Constructor()
    {
        string nombre = "nombre";
        bool entrada = false;

        Not not2 = new Not(nombre, entrada);
        Assert.That(not2.Nombre, Is.EqualTo(nombre));
        Assert.That(not2.Entrada, Is.EqualTo(entrada));

    }
    
    [Test]
    public void NotAgregarEntrada()
    {
        not1.AgregarEntrada(false);
        Assert.IsFalse(not1.Entrada);
    }
    
    [Test]
    public void NotFalse()
    {
        not1.AgregarEntrada(false);
        Assert.IsTrue(not1.Calcular());
    }
    
    [Test]
    public void NotTrue()
    {
        not1.AgregarEntrada(true);
        Assert.IsFalse(not1.Calcular());
    }
}