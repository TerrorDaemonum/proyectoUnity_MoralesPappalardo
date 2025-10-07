public class Player
{
    private float velocidad;
    private float velocidadActual;
    private float aceleracion;

    public Player(float velocidad, float aceleracion)
    {
        this.velocidad = velocidad;
        this.aceleracion = aceleracion;
        velocidadActual = 0f;

    }

    public float VelocidadActual { get => velocidadActual; set => velocidadActual = value; }
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
}