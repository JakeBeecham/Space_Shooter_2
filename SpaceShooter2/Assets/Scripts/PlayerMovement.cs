using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float h, v;
    public float movementSpeed = 200;
    Rigidbody2D body;

    Vector3 mousePosition;
    Vector3 direction;

	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        direction = mousePosition - transform.position;
        direction.Normalize();

        transform.up = direction;
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(h, v) * movementSpeed * Time.deltaTime;
    }
}
