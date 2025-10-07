using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void Move(Transform transform,Player player, float direccion)
    {
        if (transform == null || player == null) return;

        player.VelocidadActual = direccion * player.Velocidad;
        transform.Translate(direccion * player.Velocidad * Time.deltaTime, 0, 0);
    }


}
