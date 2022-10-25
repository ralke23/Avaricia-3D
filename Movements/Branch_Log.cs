using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch_Log : MonoBehaviour
{
    public GameObject BranchUI;
    public GameObject Branch;
    public Animator playerAnimator;
    public GameObject fireLight;
    public GameObject Torch;
    public GameObject QText;
    //public Animator branchAnimator;
    // public GameObject Torch;
    // public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        {
            if (Input.GetKey(KeyCode.Q) && fireLight.activeSelf)
            {
                Debug.Log("Taking_Branch");
                playerAnimator.SetBool("Caminar", false);
                playerAnimator.SetBool("Lifting", true);
                playerAnimator.GetComponent<Player>().enabled = false;
                //Branch.GetComponent<MeshRenderer>().enabled = false;
                BranchUI.GetComponent<Animator>().SetBool("Branch_UI_In", true);
                BranchUI.SetActive(true);
            }
            if (other.gameObject.tag == "Player" && fireLight.activeSelf)
            {
                Debug.Log("QText Active");
                //ballAnimator.SetBool("Shoot", false);
                QText.SetActive(true);
            }
            else
            {
                Debug.Log("Hint_Missed");               
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("QText Disabled");
            //ballAnimator.SetBool("Shoot", false);
            QText.SetActive(false);
        }
    }
    public void Back()
            {
                //branchLog.GetComponent<Animator>().SetBool("Branch_UI_In", false);
         playerAnimator.GetComponent<Player>().enabled = true;
         playerAnimator.SetBool("Lifting", false);
         playerAnimator.SetBool("Caminar", false);
            //playerAnimator.SetBool("Lifting", true);
             Debug.Log("Activating Torch");
         BranchUI.GetComponent<Animator>().SetBool("Branch_UI_In", false);
         Branch.SetActive(false);
         Torch.SetActive(true);
        QText.SetActive(false);
        //Torch.SetActive(true);
        //Light.SetActive(true);
    }
 }

