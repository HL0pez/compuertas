namespace Compuertas_logicas;

public class Not: ICompuerta
{
    public bool Entrada { get; set; }

    public Not(bool entrada)
    {
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