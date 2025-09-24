namespace CompuertasTest;
using Compuertas_logicas;
public class AndTests
{
    private And _and1;

    [SetUp]
    public void Setup()
    {
        _and1 = new And(true, true);
    }
    
    [Test]
    public void AndAgregarEntrada()
    {
        int entradasIniciales = _and1.Entradas.Count;
        _and1.AgregarEntrada(false);
        int cantEntradas = _and1.Entradas.Count;
        Assert.That(cantEntradas,Is.EqualTo(entradasIniciales + 1));
    }
    
    [Test]
    public void AndFalseYTrue()
    {
        _and1.AgregarEntrada(false);
        Assert.IsFalse(_and1.Calcular());
    }
    
    [Test]
    public void AndTrueYTrue()
    {
        _and1.Entradas = new List<bool> { true, true };
        Assert.IsTrue(_and1.Calcular());
    }
}