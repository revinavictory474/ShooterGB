using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class MyPlayer : MonoBehaviour
{
    public static MyPlayer myPlayer;
    PlayerHP playerHP;
    PlayerShot playerShot;
    PlayerMine playerMine;


    private void Awake()
    {
        playerHP.SetAwakeHP();
    }

    private void Start()
    {
        playerHP.SetStartHP();
    }
    private void Update()
    {
        playerShot.Shot();
        playerMine.SetMine();
    }

}

