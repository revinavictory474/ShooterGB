using System.Collections;
using UnityEngine;


public class PlayerMine : MonoBehaviour
{
    [SerializeField] private GameObject mine;
    [SerializeField] private int mineCount = 3;
    [SerializeField] private Transform mineStartPosition;
    private float currentReloadTime;

    public void SetMine()
    {
        if (Input.GetMouseButtonDown(1) && mineCount > 0)

        {
            Instantiate(mine, mineStartPosition.position, Quaternion.identity);
            mineCount--;
        }

        if (currentReloadTime > 0) currentReloadTime -= Time.deltaTime;

    }


}
