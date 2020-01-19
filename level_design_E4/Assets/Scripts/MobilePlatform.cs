using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatform : MonoBehaviour
{
    public Transform meshTransform;
    public float movementSpeed = 1f;
    public Transform minMovementPoint;
    public Transform maxMovementPoint;
    public bool active = true;


    private float currentProgress = 0f;
    private float movingTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (active)
        {
            movingTime += Time.deltaTime;
            currentProgress = (Mathf.Sin(movingTime * movementSpeed - Mathf.PI/2) + 1) / 2f; // Oscillates between 0,1
            meshTransform.position = Vector3.Lerp(minMovementPoint.position, maxMovementPoint.position, currentProgress);
        }
    }

    public void Activate()
    {
        active = true;
    }
}
