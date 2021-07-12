using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public FlowManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Safety Hat")
        {
            manager.wearSafetyHat();
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "Safety Goggles")
        {
            manager.wearSafetyGoogle();
            Destroy(other.gameObject);
        }
    }
}
