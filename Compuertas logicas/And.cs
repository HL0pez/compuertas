namespace Compuertas_logicas;

public class And : ICompuerta
{
    public List<bool> Entradas { get; set; }

    public And(bool entrada1, bool entrada2)
    {
        this.Entradas = new List<bool>{entrada1,entrada2};
    }

    public bool Calcular()
    {
        foreach (var entrada in this.Entradas)
        {
            if (!entrada)
            {
                return false;
            }
        }
        return true;
    }
    
    public void AgregarEntrada(bool entrada)
    {
        this.Entradas.Add(entrada);
    }
}