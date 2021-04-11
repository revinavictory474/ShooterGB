using UnityEngine;

public class Mine : MonoBehaviour
{
    private Rigidbody rigidbody;
    public void Init()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<iTakeDamage>().TakeDamage(100);
        Destroy(gameObject);
    }
}
