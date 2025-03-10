using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce;
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);

            Destroy(bullet, 1f);
        }
    }
}
