namespace CompuertasTest;
using Compuertas_logicas;

public class OrTests
{
    private Or or1;

[SetUp]
    public void Setup()
    { 
        or1 = new Or("or", false);
    }
    
    [Test]
    public void Constructor()
    {
        string nombre = "nombre";
        bool entrada = false;

        Or or2 = new Or(nombre, entrada);
        Assert.That(or2.Nombre, Is.EqualTo(nombre));
    }

    [Test]
    public void OrAgregarEntrada()
    {
        int entradasIniciales = or1.Entradas.Count;
        or1.AgregarEntrada(false);
        int cantEntradas = or1.Entradas.Count;
        Assert.That(cantEntradas,Is.EqualTo(entradasIniciales + 1));
    }
    
    [Test]
    public void OrFalseYFalse()
    {
        or1.AgregarEntrada(false);
        Assert.IsFalse(or1.Calcular());
    }
    
    [Test]
    public void OrFalseYTrue()
    {
        or1.AgregarEntrada(true);
        Assert.IsTrue(or1.Calcular());
    }
    
    [Test]
    public void OrTrueYTrue()
    {
        or1.Entradas = new List<bool> { true, true };
        Assert.IsTrue(or1.Calcular());
    }
    
}