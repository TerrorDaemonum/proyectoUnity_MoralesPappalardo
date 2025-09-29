using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// Fuerza utilizada para aplicar movimiento
    /// </summary>
    [SerializeField] private Vector3 fuerzaPorAplicar = new Vector3(0f, 0f, 300f);
    /// <summary>
    /// Representa el tiempo que ha transcurrido
    /// desde la ultima aplicacion de fuerzas
    /// </summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo se aplican fuerzas
    /// </summary>
    [SerializeField] private float intervaloDeTiempo = 2f;
    private Rigidbody rb;
    #endregion

    #region Ciclo de Vida del Script
    void Start()
    {
        tiempoDesdeUltimaFuerza = 0f;
        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogWarning("Rigidbody no encontrado en el GameObject.");
    }

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloDeTiempo)
        {
            if (rb != null) rb.AddForce(fuerzaPorAplicar, ForceMode.Force);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
    #endregion
}