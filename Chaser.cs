using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{   //adds the player objects transform into the inspector. 
    public Transform targetTransform;
    public float speed = 7;

    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * speed; 

        float distanceToTarget = displacementFromTarget.magnitude;

        if (distanceToTarget > 1.5)
        {
            transform.Translate(velocity * Time.deltaTime);

        }

        

    }
}
