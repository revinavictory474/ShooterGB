using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Turet : MonoBehaviour, iTakeDamage
{
    [SerializeField] private Transform top;
    [SerializeField] private Transform bulletPosition;
    [SerializeField] private GameObject bullet;
    [SerializeField] private int currentReloadTime = 1;
    [SerializeField] private int reloadTime = 2;
    [SerializeField] private int hp;

    private System.Timers.Timer timer;

    private void Awake()
    {
        hp = 150;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0) Death();
    }
    public void Death()
    {
        Destroy(gameObject);
    }
    public Turet()
    {
        timer = new System.Timers.Timer();
        timer.Enabled = false;
        timer.Interval = 1000;
        timer.Elapsed += Timer_Elapsed;
    }

    private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        if (currentReloadTime < reloadTime)
            currentReloadTime++;
        else
        {
            currentReloadTime = 1;
            timer.Enabled = false;
        }
    }

  
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            top.LookAt(other.transform);
            

            if (!timer.Enabled)
            {
                //var createBullet = Instantiate(bullet, bulletPosition.position, Quaternion.identity).GetComponent<Bullet>();
                //createBullet.Init();
                timer.Enabled = true;
            }
        }
    }

       
}
