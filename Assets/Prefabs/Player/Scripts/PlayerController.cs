using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private IMovementStrategy movimientoLateral;
    private IMovementStrategy movimientoAcelerado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        movimientoLateral = new MovimientoLateral();
        movimientoAcelerado = new MovimientoAcelerado();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        ICommand command = Input.GetKey(KeyCode.Space)
            ? new AcelerateMoveCommand(playerMovement, movimientoAcelerado, horizontalInput)
            : new MoveCommand(playerMovement, movimientoLateral, horizontalInput);
        command.Execute();
        
    }
}
