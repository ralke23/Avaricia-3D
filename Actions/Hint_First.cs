using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_First : MonoBehaviour
{
	public GameObject HintFirst;
	public Animator playerAnimator;
	public GameObject FireLight;
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
				Debug.Log("Information_Tree_Works");
				HintFirst.GetComponent<Animator>().SetBool("Hint_First_In", true);
				playerAnimator.SetBool("Caminar", false);
				//playerAnimator.GetComponent<Animator>().enabled = false;
				playerAnimator.GetComponent<Player>().enabled = false;
			}
			else if (other.gameObject.tag == "Player")
			{
				Debug.Log("QText Active");
				//ballAnimator.SetBool("Shoot", false);
				QText.SetActive(true);
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
		HintFirst.GetComponent<Animator>().SetBool("Hint_First_In", false);
		playerAnimator.GetComponent<Player>().enabled = true;
		FireLight.SetActive(true);
		Debug.Log("Information_Tree_Out");
	}

}
