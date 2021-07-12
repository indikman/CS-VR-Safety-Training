using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stud : MonoBehaviour
{
    public FlowManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "blade")
        {
            if(manager.safetyGoggle && manager.safetyHat && manager.chainSaw)
            {
                manager.completeSaw();
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Rigidbody>().useGravity = true;
            }
            
        }
    }
}
