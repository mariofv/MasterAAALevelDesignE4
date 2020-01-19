using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatform : MonoBehaviour
{
    public Transform meshTransform;
    public float movementSpeed = 1f;
    public Transform minMovementPoint;
    public Transform maxMovementPoint;

    private float currentProgress = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentProgress = (Mathf.Sin(Time.fixedTime * movementSpeed) + 1) / 2f; // Oscillates between 0,1
        meshTransform.position = Vector3.Lerp(minMovementPoint.position, maxMovementPoint.position, currentProgress);
    }
}
