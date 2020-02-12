using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    public int score = 100;

    [HideInInspector]
    public Spawner source;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            source.manager.SubtractLife();
            DestroyEnemy();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            source.manager.AddToScore(score);
            DestroyEnemy();
        }
    }

    void DestroyEnemy()
    {
        source.OnEnemyDestroyed();
        Destroy(gameObject);
    }
}