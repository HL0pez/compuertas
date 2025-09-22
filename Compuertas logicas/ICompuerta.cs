namespace Compuertas_logicas;

public interface ICompuerta
{
    public string Nombre { get; set; } 
    public bool Calcular();
    public void AgregarEntrada(bool entrada);
}