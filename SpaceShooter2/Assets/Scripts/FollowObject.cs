using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform objectToFollow;
    Vector3 targetPosition;

	void Update ()
    {
        targetPosition.x = objectToFollow.position.x;
        targetPosition.y = objectToFollow.position.y;
        targetPosition.z = transform.position.z;

        transform.position = targetPosition;
    }
}