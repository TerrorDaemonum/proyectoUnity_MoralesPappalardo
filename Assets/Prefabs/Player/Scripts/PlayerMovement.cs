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
    //private float velocidadLateral;
    /// <summary>
    /// Representa la estrategia de movimiento a utilizar
    /// </summary>
    private IMovementStrategy strategy;
    /// <summary>
    /// Clase Player que contiene datos del jugador
    /// </summary>
    private Player player;
    #endregion

    #region Ciclo de Vida del Script
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0f, 0f, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloDeTiempo = 2f;
        player = new Player(10f,10f);

        rb = GetComponent<Rigidbody>();
    }

   // private void Update()
  //  {
        /// <summary>
        /// Llamada a la estrategia de movimiento, pasando el modelo Player
        /// </summary>
       // strategy.Move(transform, velocidadLateral, playerData, 0);
  //  }

    //Logica para aplicacion de fuerzas

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloDeTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
    //Lamma al movimiento lateral
    public void MovePlayer(float input)
    {
        if (strategy == null) return;
        strategy.Move(transform, player, input);
    }
    #endregion

    #region Logica del Script

  
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }
    public Player getPlaayer() => player;
    #endregion
}