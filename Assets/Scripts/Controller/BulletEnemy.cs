using UnityEngine;


public class BulletEnemy: MonoBehaviour
{
    [SerializeField] private int damage = 10;
    private int force = 50;
    private int timeLive = 1000;
    private int currentTimme;

    public void Init()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.forward * force, ForceMode.Impulse);
    }

    private void Update()
    {
        if (currentTimme < timeLive) currentTimme++;
        else Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<iTakeDamage>().TakeDamage(damage);
            Destroy(this);
        }
    }
}
