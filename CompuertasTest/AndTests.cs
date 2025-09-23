namespace CompuertasTest;
using Compuertas_logicas;
public class AndTests
{
    private And and1;

    [SetUp]
    public void Setup()
    {
        and1 = new And("and", true);
    }
    [Test]
    public void Constructor()
    {
        string nombre = "nombre";
        bool entrada = false;

        And and2 = new And(nombre, entrada);
        Assert.That(and2.Nombre, Is.EqualTo(nombre));
    }
    
    [Test]
    public void AndAgregarEntrada()
    {
        int entradasIniciales = and1.Entradas.Count;
        and1.AgregarEntrada(false);
        int cantEntradas = and1.Entradas.Count;
        Assert.That(cantEntradas,Is.EqualTo(entradasIniciales + 1));
    }
    
    [Test]
    public void AndFalseYTrue()
    {
        and1.AgregarEntrada(false);
        Assert.IsFalse(and1.Calcular());
    }
    
    [Test]
    public void AndTrueYTrue()
    {
        and1.Entradas = new List<bool> { true, true };
        Assert.IsTrue(and1.Calcular());
    }
}