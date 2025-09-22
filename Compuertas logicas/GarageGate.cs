namespace Compuertas_logicas;

public class GarageGate
{
    public bool AbrirPuerta(bool a, bool b, bool c)
    {
        And and1 = new And("And1", a);
        and1.AgregarEntrada(b);
        and1.AgregarEntrada(c);
        
        Not nota = new Not("Nota", a);
        Not notb = new Not("Notb", b);
        And and2 = new And("AndCond1", notb.Calcular());
        and2.AgregarEntrada(nota.Calcular());
        and2.AgregarEntrada(c);

        Or abrirGarage = new Or("Abrir garage", and1.Calcular());
        abrirGarage.AgregarEntrada(and2.Calcular());
        if (abrirGarage.Calcular())
        {
            Console.WriteLine($"La puerta se abrió");
            return true;
        }
        else
        {
            Console.WriteLine("La puerta no se abrió");
            return false;
        }
    }
}