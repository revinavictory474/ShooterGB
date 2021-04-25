using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Observer : MonoBehaviour
{
    public Transform player;
    public Enemy enemy;
    //public GameEnding gameEnding;

    bool isPlayerInRange;
    private float currentReloadTime = 0;
    [SerializeField] private float reloadTime = 3.0f;
    [SerializeField] private int damage = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            isPlayerInRange = false;
        }
    }

    void Update()
    {
        if (isPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player && currentReloadTime <= 0)
                {
                    enemy.GetComponent<Animator>().SetBool("attack", true);
                    player.GetComponent<iTakeDamage>().TakeDamage(damage);
                    currentReloadTime = reloadTime;
                }
                if (currentReloadTime > 0) currentReloadTime -= Time.deltaTime;
            }
        }
    }
}

