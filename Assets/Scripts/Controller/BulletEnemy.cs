using UnityEngine;


public class BulletEnemy: BulletModel
{
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<iTakeDamage>().TakeDamage(damage);
            Destroy(this);
        }
    }
}
