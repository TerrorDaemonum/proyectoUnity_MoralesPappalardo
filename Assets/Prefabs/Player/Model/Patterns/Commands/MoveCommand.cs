
using UnityEngine;

public class MoveCommand : ICommand
{
  private readonly PlayerMovement playerMovement;
  private readonly IMovementStrategy strategy;
  private readonly float input;

    public MoveCommand(PlayerMovement playerMovement, IMovementStrategy strategy, float input)
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
