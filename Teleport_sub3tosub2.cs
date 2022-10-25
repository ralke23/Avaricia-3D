using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_sub3tosub2 : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_sub2_true;
    public GameObject Objects_sub2_true;
    ///public GameObject Floor_sub2_false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == tagTeleport)
        {
        other.transform.position = exitPoint.position;
        Floor_sub2_true.gameObject.SetActive(true);
        Objects_sub2_true.gameObject.SetActive(true);
            ///Floor_sub2_false.gameObject.SetActive(false);
            Debug.Log("Entering Floor_sub2");
        }

    }
}