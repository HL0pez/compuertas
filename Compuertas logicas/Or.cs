namespace Compuertas_logicas;

public class Or: ICompuerta
{
    public List<bool> Entradas { get; set; }

    public Or(bool entrada1, bool entrada2)
    {
        this.Entradas = new List<bool>{entrada1,entrada2};
    }
    public bool Calcular()
    {
        foreach (var entrada in this.Entradas)
        {
            if (entrada)
            {
                return true;
            }
        }
        return false;
    }

    public void AgregarEntrada(bool entrada)
    {
        this.Entradas.Add(entrada);
    }
}