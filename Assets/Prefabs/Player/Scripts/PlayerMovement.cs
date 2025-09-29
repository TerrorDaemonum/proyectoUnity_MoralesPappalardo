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
    /// <summary>
    /// Indica la velocidad aplicada en el movimiento lateral
    /// </summary>
    private float velocidadLateral;
    /// <summary>
    /// Representa la estrategia de movimiento a utilizar
    /// </summary>
    private IMovementStrategy strategy;
    #endregion

    #region Ciclo de Vida del Script
    void Start()
    {
        tiempoDesdeUltimaFuerza = 0f;
        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogWarning("Rigidbody no encontrado en el GameObject.");
        velocidadLateral = 5f;
        SetStrategy(new MovimientoAcelerado());
    }
    private void Update()
    {
       strategy.Move(transform,velocidadLateral);
    }
    //Logica para aplicacion de fuerzas
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
    #region Logica del Script
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }
    #endregion
}