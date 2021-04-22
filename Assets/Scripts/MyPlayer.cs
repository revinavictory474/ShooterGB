using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class MyPlayer : MonoBehaviour, IPlayer
{
    private float _rotSpeed = 10.0f;
    private float _moveSpeed = 6.0f;

    private JumpPlayer jumpPlayer;
    public int Hp { get ; set; }
    private IWeapon _weapon { get; set; }
    private IMove _movement;
    private IJump _jumpAndFall;

    public MyPlayer(int hp, IWeapon weapon, IMove move, IJump jump)
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

}

