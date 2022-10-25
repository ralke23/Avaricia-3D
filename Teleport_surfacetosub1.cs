using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_surfacetosub1 : MonoBehaviour
{
    public Transform exitPoint;
    public string tagTeleport = "Player";
    public GameObject Floor_surface1_false;
    public GameObject Objects_surface1_false;
    public GameObject Objects_sub1_true;
    public GameObject Subterrain_Music;
    public GameObject Outside_Music;
    //public GameObject Spectres_sub1_true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagTeleport)
        {
            other.transform.position = exitPoint.position;
            Floor_surface1_false.gameObject.SetActive(false);
            Objects_surface1_false.gameObject.SetActive(false);
            Objects_sub1_true.gameObject.SetActive(true);
            //Spectres_sub1_true.gameObject.SetActive(true);
            //Subterrain_Music.gameObject.SetActive(true);
            //Outside_Music.gameObject.SetActive(false);
            Debug.Log("Dissapearing Floor_sub1");
        }

    }
}
