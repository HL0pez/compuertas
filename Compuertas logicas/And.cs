using System.Security.Cryptography;

namespace Compuertas_logicas;

public class And : ICompuerta
{
    public string Nombre { get; set; }
    public List<bool> Entradas { get; set; }

    public And(string name, bool primerEntrada)
    {
        this.Nombre = name;
        this.Entradas = new List<bool>{primerEntrada};
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