using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    public GameObject tick_goggle;
    public GameObject tick_hat;
    public GameObject tick_chainsaw;
    public GameObject tick_saw;
     
    public bool safetyGoggle;
    public bool safetyHat;
    public bool chainSaw;

    public void wearSafetyGoogle()
    {
        tick_goggle.SetActive(true);
        safetyGoggle = true;
    }

    public void wearSafetyHat()
    {
        tick_hat.SetActive(true);
        safetyHat = true;
    }

    public void grabChainSaw()
    {
        tick_chainsaw.SetActive(true);
        chainSaw = true;
    }

    public void releaseChainSaw()
    {
        tick_chainsaw.SetActive(false);
        chainSaw = false;
    }

    public void completeSaw()
    {
        tick_saw.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        tick_chainsaw.SetActive(false);
        tick_goggle.SetActive(false);
        tick_hat.SetActive(false);
        tick_saw.SetActive(false);
    }

    
}
