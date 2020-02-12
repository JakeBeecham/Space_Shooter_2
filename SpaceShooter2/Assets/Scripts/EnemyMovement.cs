using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float movementSpeed = 100;
    GameObject target;
    Vector3 direction;

	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	void FixedUpdate()
    {
		if(target != null)
        {
            direction = target.transform.position - transform.position;
            direction.z = 0;
            direction.Normalize();

            body.velocity = direction * movementSpeed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
	}
}