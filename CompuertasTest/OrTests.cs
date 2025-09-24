namespace CompuertasTest;
using Compuertas_logicas;

public class OrTests
{
    private Or _or1;

[SetUp]
    public void Setup()
    { 
        _or1 = new Or(false,false);
    }

    [Test]
    public void OrAgregarEntrada()
    {
        int entradasIniciales = _or1.Entradas.Count;
        _or1.AgregarEntrada(false);
        int cantEntradas = _or1.Entradas.Count;
        Assert.That(cantEntradas,Is.EqualTo(entradasIniciales + 1));
    }
    
    [Test]
    public void OrFalseYFalse()
    {
        _or1.AgregarEntrada(false);
        Assert.IsFalse(_or1.Calcular());
    }
    
    [Test]
    public void OrFalseYTrue()
    {
        _or1.AgregarEntrada(true);
        Assert.IsTrue(_or1.Calcular());
    }
}