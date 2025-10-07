using UnityEngine;

public class AcelerateMoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly IMovementStrategy strategy;
    private readonly float input;

    public AcelerateMoveCommand(PlayerMovement playerMovement, IMovementStrategy strategy, float input)
    {
        this.playerMovement = playerMovement;
        this.strategy = strategy;
        this.input = input;
    }

public void Execute()
    {
        if (playerMovement == null || strategy == null) return;
        playerMovement.SetStrategy(strategy);
        playerMovement.MovePlayer(input);
    }
}


