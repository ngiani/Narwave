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

		int health = player.gameObject.GetComponent<Character> ().health;
		int maxHealth = player.gameObject.GetComponent<Character> ().maxHealth;
		float barValue = (float)health / (float)maxHealth;

		this.gameObject.GetComponent<Slider> ().value = barValue;

	}
}
