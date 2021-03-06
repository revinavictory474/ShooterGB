using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, iTakeDamage
{
    public static Enemy myEnemy;
    public WaypointsPatrol wpPatrol;

    [SerializeField] private int hp = 1;
    [SerializeField] private Transform dist; 
    [SerializeField] private float speed = 1;
    [SerializeField] private Animator animator;
    [SerializeField] private float reloadTime = 1.0f;
    public float hpPlayer;
    public bool IsDead { get; private set; }


    private void Awake()
    {
        hp = 50;
    }
    void Start()
    {
        //IsDead = false;
        //hpPlayer = PlayerHP.playerHP.currentHp;
        //animator = GetComponent<Animator>();
    }

    public void TakeDamage(int dam)
    {
        hp -= dam;
        animator.SetBool("damage", true);
        if (hp <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        IsDead = true;
        animator.SetBool("death", true);
        Destroy(gameObject, 5);
    }

}
