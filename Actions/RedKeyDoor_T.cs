using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKeyDoor_T : MonoBehaviour
{
    public Light redKDLight;
    public GameObject redKDPivot;

    void Start()
    {
            redKDPivot = GameObject.Find("Locator.Door.redkey");
    }
    void OnTriggerEnter()
    {
        if (redKDLight.enabled == true)
        {
            redKDPivot.GetComponent<Animator>().SetBool("Open", true);
        }
    }
}
