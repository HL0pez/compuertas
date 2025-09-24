using Compuertas_logicas;
namespace CompuertasTest;

public class NotTests
{
    private Not _not1;

    [SetUp]
    public void Setup()
    {
        _not1 = new Not( true);
    }
    
    [Test]
    public void NotAgregarEntrada()
    {
        _not1.AgregarEntrada(false);
        Assert.IsFalse(_not1.Entrada);
    }
    
    [Test]
    public void NotFalse()
    {
        _not1.AgregarEntrada(false);
        Assert.IsTrue(_not1.Calcular());
    }
    
    [Test]
    public void NotTrue()
    {
        _not1.AgregarEntrada(true);
        Assert.IsFalse(_not1.Calcular());
    }
}