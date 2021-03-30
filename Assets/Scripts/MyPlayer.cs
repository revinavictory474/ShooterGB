using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class MyPlayer : MonoBehaviour, iTakeDamage, iHealth
{
    public static MyPlayer myPlayer;
    public SlideHealth healthBar;

    #region Properties
    [SerializeField] public int currentHp;
    [SerializeField] public int maxHp;
    [SerializeField] public float speed = 9f;
    [SerializeField] private float jumpForce = 300f;
    [SerializeField] private float rotationSpeed = 1f;
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
        maxHp = 100;
        myPlayer = this;
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        currentHp = maxHp;
        healthBar.SetMaxHealth(maxHp);
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovementLogic();
        Shot();
    }

    private void MovementLogic()
    {
        direction.z = Input.GetAxis("Vertical") * speed;
        direction.x = Input.GetAxis("Horizontal") * rotationSpeed;
        direction.y = Input.GetAxis("Jump");
        var rotation = direction.x * Time.deltaTime;
        var move = direction.z * Time.deltaTime;
        var jump = direction.y;
        transform.Translate(0, 0, move);
        transform.Rotate(0, rotation, 0);
    }

       
    private void Shot()
    {
        if (Input.GetMouseButtonDown(0) && currentReloadTime <= 0)
        {
            
            {
                var createBullet = Instantiate(bullet, bulletStartPosition.position, transform.rotation).GetComponent<BulletPlayer>();
                createBullet.Init();
                audioSource.Play();
                currentReloadTime = reloadTime;
            }
        }

        if (Input.GetMouseButtonDown(1) && mineCount > 0)
        {
            Instantiate(mine, mineStartPosition.position, Quaternion.identity);
            mineCount--;
        }

        if (currentReloadTime > 0) currentReloadTime -= Time.deltaTime;
    }
    public void TakeDamage(int dam)
    {
        currentHp -= dam;
        healthBar.SetHealth(currentHp);
        if (currentHp <= 0) Death();
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

