using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageMultiplier : MonoBehaviour {

	public GameObject player;
	public List<Sprite> sprites;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int multiplier = player.GetComponent<Character> ().multiplier;

		switch (multiplier) {

			case 1:
				transform.GetComponent<Image> ().sprite = sprites [0];
				break;
			case 2:
				transform.GetComponent<Image> ().sprite = sprites [1];
				break;
			case 3:
				transform.GetComponent<Image> ().sprite = sprites [2];
				break;
			case 4:
				transform.GetComponent<Image> ().sprite = sprites [3];
				break;
			default:
				transform.GetComponent<Image> ().sprite = null;
				break;
		}
	}
}
