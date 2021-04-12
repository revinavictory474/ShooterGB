using System.Collections;
using UnityEngine;



public class Player : MonoBehaviour, iTakeDamage, iHealth
{
    public static Player myPlayer;
    public SlideHealth healthBar;

    #region Properties
    public int currentHp;
    public int maxHp;
    //private AudioSource audioSource = null;
    #endregion

    private void Awake()
    {
        maxHp = 100;
        myPlayer = this;
        //audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        currentHp = maxHp;
        healthBar.SetMaxHealth(maxHp);
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

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        healthBar.SetHealth(currentHp);
        if (currentHp <= 0) Death();
    }

    public void Death()
    {
        Destroy(gameObject);
    }

}
