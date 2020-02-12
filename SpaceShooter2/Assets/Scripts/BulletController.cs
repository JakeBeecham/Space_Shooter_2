using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }
    }
}