using UnityEngine;

public class Player : IPlayer
{
    private float _rotSpeed = 10.0f;
    private float _moveSpeed = 6.0f;

    private JumpPlayer jumpPlayer;

    public int Hp { get; set; }
    public IWeapon Weapon { get; set; }
    //public MovementPlayer Movement { get; set; }
    public IMove Move { get; }
    //public IJump Jump { get; }

    //public Player(int hp, IWeapon weapon, IMove move, IJump jump)
    public Player(int hp, IWeapon weapon, IMove move)
    {
        Hp = hp;
        Weapon = weapon;
        Move = move;
        //Jump = jump;
        //Movement = movement;
    }
}

