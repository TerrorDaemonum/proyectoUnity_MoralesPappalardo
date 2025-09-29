using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velovidadActual = 0f;
    private float aceleracion = 2f;

    public void Move(Transform transform, float speed)
    {
       velovidadActual += Input.GetAxis("Horizontal") * aceleracion * Time.deltaTime;
       velovidadActual = Mathf.Clamp(velovidadActual, -speed, speed);
        transform.Translate(velovidadActual * Time.deltaTime, 0, 0);
    }
}
