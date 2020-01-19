using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivator : MonoBehaviour
{
    public Transform activatedPosition;
    public Activable activableObject;

    private bool activated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ActivateButton()
    {
        activated = true;
        transform.position = activatedPosition.position;
        activableObject.Activate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!activated && collision.gameObject.tag == "Player")
        {
            ActivateButton();
        }
    }
}
