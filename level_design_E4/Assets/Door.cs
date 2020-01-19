using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform closePosition;
    public Transform openPosition;
    public Transform meshTransform;
    public float openingTime = 1f;

    private bool opening = false;
    private float openingCurrentTime = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            openingCurrentTime += Time.deltaTime;
            meshTransform.position = Vector3.Lerp(closePosition.position, openPosition.position, openingCurrentTime / openingTime);
            opening = openingCurrentTime < openingTime;
        }
    }

    public void OpenDoor()
    {
        opening = true;
    }
}
