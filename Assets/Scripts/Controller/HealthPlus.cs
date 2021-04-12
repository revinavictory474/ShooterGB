using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlus : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            other.GetComponent<iHealth>().Health(25);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
