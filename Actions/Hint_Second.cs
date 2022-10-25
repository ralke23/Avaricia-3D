using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_Second : MonoBehaviour
{
	public GameObject HintSecond;
	public Animator playerAnimator;
	public GameObject Hint2Walls;
	public GameObject SpectreHint2;
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
				Debug.Log("Hint_Second_Works");
				HintSecond.GetComponent<Animator>().SetBool("Hint_Second_In", true);
				playerAnimator.SetBool("Caminar", false);
				//playerAnimator.GetComponent<Animator>().enabled = false;
				playerAnimator.GetComponent<Player>().enabled = false;
			}
			if (other.gameObject.tag == "Player")
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
		HintSecond.GetComponent<Animator>().SetBool("Hint_Second_In", false);
		playerAnimator.GetComponent<Player>().enabled = true;
		Hint2Walls.SetActive(false);
		QText.SetActive(false);
		//SpectreHint2.SetActive(true);
		Debug.Log("Hint_Second_Out");
	}

}
