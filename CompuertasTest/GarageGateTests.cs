namespace CompuertasTest;
using Compuertas_logicas;

public class GarageGateTests
{
    private GarageGate puerta;
    
    [SetUp]
    public void SetUp()
    {
        puerta = new GarageGate();
    }

    [Test]
    public void CasoVerdadero1()
    {
        Assert.That(true,Is.EqualTo(puerta.AbrirPuerta(true,true,true)));
    }
    
    [Test]
    public void CasoVerdadero2()
    {        
        Assert.That(true,Is.EqualTo(puerta.AbrirPuerta(false,false,true)));
    }
    
    [Test]
    public void CasoFalso()
    {
        Assert.That(false,Is.EqualTo(puerta.AbrirPuerta(true,false,true)));
    }
}