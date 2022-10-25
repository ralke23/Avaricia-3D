using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_sub1tosurface : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_surface1_true;
    public GameObject Objects_surface1_true;
    public GameObject Spectres_sub1_false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagTeleport)
        {
            other.transform.position = exitPoint.position;
            Floor_surface1_true.gameObject.SetActive(true);
            Objects_surface1_true.gameObject.SetActive(true);
            Spectres_sub1_false.gameObject.SetActive(false);
            // Volver a colocar magic walls
            Debug.Log("Dissapearing Floor_sub1");
        }

    }
}