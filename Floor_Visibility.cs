using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Visibility : MonoBehaviour {

public GameObject Floor_sub1;
void OnTriggerEnter()
    {
    if (gameObject.tag == "Floor_sub1")
    {
            Floor_sub1.gameObject.SetActive(false);
            Debug.Log("Dissapearing Floor_sub1");
    }
}
}
