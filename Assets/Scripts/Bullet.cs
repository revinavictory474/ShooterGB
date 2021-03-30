using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private int force = 50;
    private int timeLive = 1000;
    private int currentTimme;
    private Transform enemy;

    public void Init()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward  * force, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.forward * force, ForceMode.Impulse);
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<iTakeDamage>().TakeDamage(damage);
            Destroy(this);
        }
    }

    private void Update()
    {
        if (currentTimme < timeLive) currentTimme++;
        else Destroy(this.gameObject);
    }


}


