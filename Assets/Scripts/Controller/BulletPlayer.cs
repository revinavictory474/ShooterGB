using System.Collections;
using UnityEngine;


public class BulletPlayer : BulletModel
{
    [SerializeField] private int damage = 10;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<iTakeDamage>().TakeDamage(damage);
            Destroy(this);
        }
    }
}
