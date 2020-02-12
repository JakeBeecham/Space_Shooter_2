using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();
            body.velocity = transform.up * bulletSpeed;
        }
    }
}
