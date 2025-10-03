using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velovidadActual = 0f;
    private float aceleracion = 2f;

    public void Move(Transform transform, float speed, Player playerData)
    {
        playerData.Velocity += Input.GetAxis("Horizontal") * playerData.Acceleration * Time.deltaTime;
        playerData.Velocity = Mathf.Clamp(playerData.Velocity, -speed, speed);
        transform.Translate(playerData.Velocity * Time.deltaTime, 0, 0);

    }
}
