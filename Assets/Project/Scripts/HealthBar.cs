using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float health = player.gameObject.GetComponent<Character> ().health;

		this.gameObject.GetComponent<Slider> ().value = health;

	}
}
