using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChange : MonoBehaviour
{
    public Transform leftHandReference;
    public float minSpeed = 0.2f;
    public float maxSpeed = 1.0f;
    public float movementThreshold = 0.001f;

    private Vector3 previous;

    void Start()
    {
        if (leftHandReference != null)
        {
            previous = leftHandReference.position;
        }
    }

    void Update()
    {
        if (leftHandReference != null)
        {
            float travel = Vector3.Distance(leftHandReference.position, previous);
            previous = leftHandReference.position;
            if (travel > movementThreshold)
            {
                Time.timeScale = maxSpeed;
            }
            else
            {
                Time.timeScale = minSpeed;
            }
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
    }
}
