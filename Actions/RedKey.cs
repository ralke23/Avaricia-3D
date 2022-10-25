using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKey : MonoBehaviour
{
    public Light redkeyLight;
    
    void Start()
    {
        redkeyLight.enabled = false;
    }

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        redkeyLight.enabled = true;
        // Debug.Log("stepIn");   
    }
    void OnTriggerExit()
    {
        // Debug.Log("stepOut");
    }
    void OnTriggerStay()
    {
        // Debug.Log("isOnTile");
    }
}
