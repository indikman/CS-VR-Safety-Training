using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public FlowManager manager;

    public string GrabButton;

    [SerializeField] private Grabbable hoveredObject;
    [SerializeField] private Grabbable grabbedObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Grabbing
        if (Input.GetButtonDown(GrabButton))
        {
            if (hoveredObject != null)
            {
                
                if(hoveredObject.name == "Jigsaw")
                {
                    manager.grabChainSaw();
                }

                grabbedObject = hoveredObject;
                grabbedObject.OnGrabbed(transform);
                hoveredObject = null;

                
            }
        }

        if (Input.GetButtonUp(GrabButton))
        {
            if (grabbedObject != null)
            {
                

                if (grabbedObject.name == "Jigsaw")
                {
                    manager.releaseChainSaw();
                }
                
                grabbedObject.OnReleased();
                grabbedObject = null;

            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        hoveredObject = other.GetComponent<Grabbable>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (hoveredObject != null)
        {
            hoveredObject = null;
        }
    }

}
