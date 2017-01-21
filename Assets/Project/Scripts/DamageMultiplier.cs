using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageMultiplier : MonoBehaviour {

	public GameObject player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int multiplier = player.GetComponent<Character> ().multiplier;

		switch (multiplier) {

		case 1:
			for (int i = 0; i < 1; i++)
				transform.GetChild (i).gameObject.gameObject.GetComponent<Image> ().enabled = true;
				break;
			case 2:
				for (int i = 0; i < 2; i++)
					transform.GetChild (i).gameObject.gameObject.GetComponent<Image>().enabled = true;
				break;
			case 3:
				for (int i = 0; i < 3; i++)
					transform.GetChild (i).gameObject.gameObject.GetComponent<Image>().enabled = true;
				break;
			case 4:
				for (int i = 0; i < 4; i++)
					transform.GetChild (i).gameObject.gameObject.GetComponent<Image>().enabled = true;
				break;
			default:
				for (int i = 0; i < 4; i++)
					transform.GetChild (i).gameObject.gameObject.GetComponent<Image>().enabled = true;
					break;
		}
	}
}
