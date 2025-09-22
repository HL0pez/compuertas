namespace Compuertas_logicas;

public class Or: ICompuerta
{
    public string Nombre { get; set; }
    public List<bool> Entradas { get; set; }

    public Or(string nombre, bool primerEntrada)
    {
        this.Nombre = nombre;
        this.Entradas = new List<bool>{primerEntrada};
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