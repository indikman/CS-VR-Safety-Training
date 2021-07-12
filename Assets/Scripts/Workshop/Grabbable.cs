using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    private Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = false;
        body.useGravity = true;
    }

    
    public void OnGrabbed(Transform hand)
    {
        transform.SetParent(hand);
        body.isKinematic = true;
        body.useGravity = false;
    }

    public void OnReleased()
    {
        transform.SetParent(null);
        body.isKinematic = false;
        body.useGravity = true;
    }


}
