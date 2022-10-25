using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_sub1tosub2 : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_sub1_false;
    public GameObject Objects_sub1_false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagTeleport)
        {
            other.transform.position = exitPoint.position;
            Floor_sub1_false.gameObject.SetActive(false);
            Objects_sub1_false.gameObject.SetActive(false);
            Debug.Log("Dissapearing Floor_sub1");
        }

    }
}