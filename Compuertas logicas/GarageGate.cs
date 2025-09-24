namespace Compuertas_logicas;

public class GarageGate
{
    public bool AbrirPuerta(bool a, bool b, bool c)
    {
        And and1 = new And(a,b);
        and1.AgregarEntrada(c);
        
        Not nota = new Not(a);
        Not notb = new Not(b);
        And and2 = new And(notb.Calcular(),nota.Calcular());
        and2.AgregarEntrada(c);

        Or abrirGarage = new Or(and1.Calcular(),and2.Calcular());
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