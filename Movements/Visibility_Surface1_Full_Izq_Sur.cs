using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility_Surface1_Full_Izq_Sur : MonoBehaviour
{
    public string playerTag = "Player";
    public GameObject Floor_surface2_true;
    public GameObject Floor_surface3_true;
    public GameObject Floor_surface4_true;
    public GameObject Floor_surface5_true;
    public GameObject Floor_surface6_true;


    void OnTriggerStay(Collider other)
    {
        if (other.tag == playerTag)
        {
            Floor_surface2_true.gameObject.SetActive(true);
            Floor_surface3_true.gameObject.SetActive(true);
            Floor_surface4_true.gameObject.SetActive(true);
            Floor_surface5_true.gameObject.SetActive(true);
            Floor_surface6_true.gameObject.SetActive(true);
            Debug.Log("Active surface 2 to 6");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == playerTag)
        {
            Floor_surface2_true.gameObject.SetActive(false);
            Floor_surface3_true.gameObject.SetActive(false);
            Floor_surface4_true.gameObject.SetActive(false);
            Floor_surface5_true.gameObject.SetActive(false);
            Floor_surface6_true.gameObject.SetActive(false);
            Debug.Log("Appearing Floor_derecha_surface1");
        }
    }
}