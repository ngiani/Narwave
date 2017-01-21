﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public float speed = 1.0f;//velocità
	float rotation = 90.0f; //rotazione in gradi

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

							/*MOVIMENTO*/

		Vector2 translation = new Vector2 (Input.GetAxis ("JoyHorizontal"), Input.GetAxis("JoyVertical"));
		gameObject.transform.Translate (translation * speed * Time.deltaTime);

		//Non può superare le metà della schermo
		if (Camera.main.WorldToScreenPoint(gameObject.transform.position).x >= Screen.width / 2)
			transform.position = new Vector2(0,transform.position.y);
		
		//Non può superare i bordi dello schermo
		Vector2 leftUp = Camera.main.ScreenToWorldPoint (new Vector2(0, 0));
		if (Camera.main.WorldToScreenPoint(gameObject.transform.position).x <= 0){
			transform.position = new Vector2(leftUp.x,transform.position.y);
		}

		if (Camera.main.WorldToScreenPoint(gameObject.transform.position).y <= 0){
			transform.position = new Vector2(transform.position.x,leftUp.y);
		}

		Vector2 leftDown = Camera.main.ScreenToWorldPoint (new Vector2(0, Screen.height));
		if (Camera.main.WorldToScreenPoint(gameObject.transform.position).y >= Screen.height){
			transform.position = new Vector2(transform.position.x,leftDown.y);
		}


					/*ANGOLO*/
		float axisFive = Input.GetAxis ("AxisFive");
		float axisFour = Input.GetAxis ("AxisFour");

		//Angolo di rotazione è l'arcoseno del valore restituito dal quinto asse, convertito in gradi
		if  (axisFour >= 0)
			rotation = Mathf.Acos(-axisFive) * (180 / Mathf.PI);
		if (axisFour < 0)
			rotation = -Mathf.Acos (-axisFive) * (180 / Mathf.PI);

		transform.GetChild(0).rotation = Quaternion.AngleAxis (rotation, new Vector3(0,0,1));
	
		//Sparo
		if (Input.GetButtonDown("LeftBumper"))
			Debug.Log ("Left Bumper");
		if (Input.GetButtonDown("RightBumper"))
			Debug.Log ("Right Bumper");

		if (Input.GetAxis("LeftTrigger") > 0)
			Debug.Log("Left Trigger");
		if (Input.GetAxis ("RightTrigger") > 0)
			Debug.Log ("Right Trigger");
	
	}
}
