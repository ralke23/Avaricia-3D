using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_Third : MonoBehaviour
{
	public GameObject HintThird;
	public Animator playerAnimator;
	public GameObject Shield;
	public GameObject QText;
	public GameObject EText;
	public GameObject Walls;


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
				Debug.Log("Hint_Three_Works");
				HintThird.GetComponent<Animator>().SetBool("Hint_Third_In", true);
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
			else if (other.gameObject.tag == "Player" && Shield.activeSelf)
			{
				QText.SetActive(false);
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
			EText.SetActive(true);
		}
	}

	public void Back()
	{
		HintThird.GetComponent<Animator>().SetBool("Hint_Third_In", false);
		playerAnimator.GetComponent<Player>().enabled = true;
		Walls.SetActive(false);
		Shield.SetActive(true);
		//SpectreHint2.SetActive(true);
		Debug.Log("Hint_Second_Out");
	}
}

