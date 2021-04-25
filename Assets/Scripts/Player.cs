using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    private float _rotSpeed = 10.0f;
    private float _moveSpeed = 6.0f;

    private JumpPlayer jumpPlayer;
    public int Hp { get ; set; }
    public IWeapon _weapon { get; set; }
    public IWeapon Weapon { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    private IMove _movement;
    private IJump _jumpAndFall;

    public Player(int hp, IWeapon weapon, IMove move, IJump jump)
    {
        Hp = hp;
        _weapon = weapon;
        _movement = move;
        _jumpAndFall = jump;
    }
    
    private void Start()
    {
        var movementLogic = new MovementPlayer(transform, _moveSpeed, _rotSpeed);
        jumpPlayer._characterController = GetComponent<CharacterController>();
        jumpPlayer._vertSpeed = jumpPlayer.MinFall;
    }

    private void Update()
    {
        
    }

    public void Move()
    {
       _movement.Move();
    }

    public void Jump()
    {
        _jumpAndFall.Jump();
    }

    IMove IPlayer.Move()
    {
        throw new System.NotImplementedException();
    }

    IJump IPlayer.Jump()
    {
        throw new System.NotImplementedException();
    }
}

