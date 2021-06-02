using System.Collections;
using UnityEngine;


public class PlayerShot : BulletModel
{
    [SerializeField] private float reloadTime = 1.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletStartPosition;
    private float currentReloadTime;

    public void Shot()
    {
        if (Input.GetMouseButtonDown(0) && currentReloadTime <= 0)
        {

            {
                var createBullet = Instantiate(bullet, bulletStartPosition.position, transform.rotation).GetComponent<BulletPlayer>();
                createBullet.Init();
                //audioSource.Play();
                currentReloadTime = reloadTime;
            }
        }
        if (currentReloadTime > 0) currentReloadTime -= Time.deltaTime;
    }
}
