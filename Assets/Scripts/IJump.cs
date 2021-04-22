public interface IJump
{
    public float MoveSpeed { get; }
    public float JumpSpeed { get; }
    public float Gravity { get; }
    public float TerminalVelocity { get; }
    public float MinFall { get; }
    void Jump();
}