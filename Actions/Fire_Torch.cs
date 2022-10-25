using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Torch : MonoBehaviour
{
    public GameObject TorchUI;
    public GameObject TorchFire;
    public Animator playerAnimator;
    public GameObject Torch;
    //public Animator branchAnimator;
    // public GameObject Torch;
    // public GameObject Light;
    public GameObject Light_Checker_One;
    public GameObject Light_Checker_Two;
    public GameObject Light_Checker_Three;
    public GameObject QText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        {
            if (Input.GetKey(KeyCode.Q) && Torch.activeSelf)
            {
                Debug.Log("Taking_Torch");
                //playerAnimator.SetBool("Caminar", false);
                playerAnimator.SetBool("Lifting", true);
                playerAnimator.GetComponent<Player>().enabled = false;
                //Branch.GetComponent<MeshRenderer>().enabled = false;
                TorchUI.GetComponent<Animator>().SetBool("Torch_UI_In", true);
                TorchUI.SetActive(true);
                TorchFire.SetActive(true);
            }
            if (other.gameObject.tag == "Player" && Torch.activeSelf)
            {
                Debug.Log("QText Active");
                //ballAnimator.SetBool("Shoot", false);
                QText.SetActive(true);
            }
            else
            {
                Debug.Log("Hint_Missed");
                //playerAnimator.GetComponent<Player>().enabled = true;
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
        //playerAnimator.SetBool("Lifting", true);
        Debug.Log("Activating Torch");
        TorchUI.GetComponent<Animator>().SetBool("Torch_UI_In", false);
        //Torch.SetActive(true);
        //Light.SetActive(true);
        Light_Checker_One.SetActive(false);
        Light_Checker_Two.SetActive(false);
        Light_Checker_Three.SetActive(false);
    }
}

