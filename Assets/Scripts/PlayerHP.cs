using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayerHP : iHealth, iTakeDamage
{
    public static PlayerHP playerHP;
    MyPlayer myPlayer;
    public SlideHealth healthBar;

    public int currentHp;
    public int maxHp;

    public void SetAwakeHP()
    {
        maxHp = 100;
        MyPlayer player = new MyPlayer();
        myPlayer = player;
    }

    public void SetStartHP()
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
       // Destroy(gameObject);
    }
}

