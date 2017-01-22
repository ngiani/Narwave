using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		int score = player.GetComponent<Character> ().points;

		this.transform.GetChild(0).GetComponent<Text> ().text = score.ToString();
	}
}
