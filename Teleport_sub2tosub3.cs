using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_sub2tosub3 : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_sub2_false;
    public GameObject Objects_sub2_false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagTeleport)
        {
            other.transform.position = exitPoint.position;
            Floor_sub2_false.gameObject.SetActive(false);
            Objects_sub2_false.gameObject.SetActive(false);
            Debug.Log("Dissapearing Floor_sub2");
        }

    }
}