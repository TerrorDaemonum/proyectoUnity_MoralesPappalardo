using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
 
    public void Move(Transform transform, Player player, float direccion)
    {
        if (transform == null || player == null) return;

        player.VelocidadActual += direccion * player.Aceleracion * Time.deltaTime;
        player.VelocidadActual = Mathf.Clamp(player.VelocidadActual, -player.Velocidad, player.Velocidad);
        transform.Translate(player.VelocidadActual * Time.deltaTime, 0, 0);

    }

}
