public class Player
{
    public float Velocity { get; set; }
    public float Acceleration { get; set; }

    public Player(float velocity, float acceleration)
    {
        Velocity = velocity;
        Acceleration = acceleration;
    }
}