namespace Compuertas_logicas;

public class Not: ICompuerta
{
    public string Nombre { get; set; }
    public bool Entrada { get; set; }

    public Not(string nombre,bool entrada)
    {
        this.Nombre = nombre;
        this.Entrada = entrada;
    }
    public bool Calcular()
    {
        return !this.Entrada;
    }

    public void AgregarEntrada(bool entrada)
    {
        this.Entrada = entrada;
    }
}