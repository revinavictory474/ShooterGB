using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:Assets/Scripts/Controller/BulletPlayer.cs

public class BulletPlayer : BulletModel
{
    [SerializeField] private int damage = 10;
   
=======
public class BulletPlayer : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private int force = 50;
    private int timeLive = 1000;
    private int currentTimme;
    private Transform enemy;

    public void Init()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.forward * force, ForceMode.Impulse);
    }


>>>>>>> parent of 3780037... V1.1.4:Assets/Scripts/BulletPlayer.cs
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
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




