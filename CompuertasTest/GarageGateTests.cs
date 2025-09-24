namespace CompuertasTest;
using Compuertas_logicas;

public class GarageGateTests
{
    private GarageGate _puerta;
    
    [SetUp]
    public void SetUp()
    {
        _puerta = new GarageGate();
    }

    [Test]
    public void CasoVerdadero1()
    {
        Assert.That(_puerta.AbrirPuerta(true,true,true),Is.EqualTo(true));
    }
    
    [Test]
    public void CasoVerdadero2()
    {        
        Assert.That(_puerta.AbrirPuerta(false,false,true),Is.EqualTo(true));
    }
    
    [Test]
    public void CasoFalso()
    {
        Assert.That(_puerta.AbrirPuerta(true,false,true),Is.EqualTo(false));
    }
}