using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_sub2tosub1 : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_sub1_true;
    public GameObject Objects_sub1_true;
    ///public GameObject Floor_sub2_false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == tagTeleport)
        {
        other.transform.position = exitPoint.position;
        Floor_sub1_true.gameObject.SetActive(true);
        Objects_sub1_true.gameObject.SetActive(true);
            ///Floor_sub2_false.gameObject.SetActive(false);
            Debug.Log("Entering Floor_sub1");
        }

    }
}