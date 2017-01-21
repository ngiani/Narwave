using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public float speed = 1.0f;
	float rotation = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Movimento
		Vector2 translation = new Vector2 (Input.GetAxis ("JoyHorizontal"), Input.GetAxis("JoyVertical"));
		gameObject.transform.Translate (translation * speed * Time.deltaTime);

		if (Camera.main.WorldToScreenPoint(gameObject.transform.position).x >= Screen.width / 2)
			transform.position = new Vector2(0,transform.position.y);

		//Rotazione
		float axisFive = Input.GetAxis ("AxisFive");
		float axisFour = Input.GetAxis ("AxisFour");

		if  (axisFour >= 0)
			rotation = Mathf.Asin (axisFive) * (180 / Mathf.PI);
		if (axisFour < 0)
			rotation = -Mathf.Asin (axisFive) * (180 / Mathf.PI);

		gameObject.transform.rotation = Quaternion.AngleAxis (rotation, new Vector3(0,0,1));
	


	}
}
