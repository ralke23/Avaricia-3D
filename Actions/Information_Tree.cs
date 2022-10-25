using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information_Tree: MonoBehaviour
{

	public GameObject InformationTree;
	public Animator playerAnimator;
	public GameObject QText;

	void Start()
	{
		{
			//InformationTree.enabled = false;
		}
	}

	// Use this for initialization
	void OnTriggerStay(Collider other)
	{
		{
			if (Input.GetKey(KeyCode.Q))
			{
				Debug.Log("Hint_First_Works");
				InformationTree.GetComponent<Animator>().SetBool("Information_Tree_In", true);
				playerAnimator.SetBool("Caminar", false);
				//playerAnimator.GetComponent<Animator>().enabled = false;
				playerAnimator.GetComponent<Player>().enabled = false;
			}
		}
		if  (other.gameObject.tag == "Player")
			{
				Debug.Log("QText Active");
			//ballAnimator.SetBool("Shoot", false);
			QText.SetActive(true);
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
		InformationTree.GetComponent<Animator>().SetBool("Information_Tree_In", false);
		playerAnimator.GetComponent<Player>().enabled = true;
		Debug.Log("Information_Tree_Out");
	}

}