using UnityEngine;


public abstract class BulletModel : MonoBehaviour
{
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
}
