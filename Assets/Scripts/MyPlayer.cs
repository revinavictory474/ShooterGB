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



    #region Properties
    [SerializeField] public int currentHp;
    [SerializeField] public int maxHp;
    [SerializeField] public float speed = 9f;
    [SerializeField] private float jumpForce = 300f;
    [SerializeField] private float rotationSpeed = 0.8f;
    [SerializeField] private int damage = 10;

    private Rigidbody rigidbody;
    Vector3 direction = Vector3.zero;
    private AudioSource audioSource = null;



    [Header("Bullet")]
    [SerializeField] private float reloadTime = 1.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletStartPosition;

    [Header("Mine")]
    [SerializeField] private GameObject mine;
    [SerializeField] private int mineCount = 3;
    [SerializeField] private Transform mineStartPosition;

    private float currentReloadTime = 0;


    #endregion


    private void Awake()
    {
        playerHP.SetAwakeHP();
    }

    private void Start()
    {

        playerHP.SetStartHP();

        currentHp = maxHp;
       // healthBar.SetMaxHealth(maxHp);
        rigidbody = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        playerShot.Shot();
        playerMine.SetMine();
    }


    public void Death()
    {
        Destroy(gameObject);
    }

    public void Health(int hp)
    {
        if (hp + currentHp >= maxHp)
        {
            currentHp = maxHp;
        }
        else
        {
            currentHp += hp;
        }
    }

    


}

