using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    public string moveHorizontalAxis = "JoyHorizontal";
    public string moveVerticalAxis = "JoyVertical";
    public string aimHorizontalAxis = "AxisFour";
    public string aimVerticalAxis = "AxisFive";
    public string fireButton = "RightBumper";


    public float speed = 1.0f;//velocità
	public float rotation = 90.0f; //rotazione in gradi
    public Transform cannon;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

							/*MOVIMENTO*/

		Vector2 translation = new Vector2 (Input.GetAxis (moveHorizontalAxis), Input.GetAxis(moveVerticalAxis));
		gameObject.transform.Translate (translation * speed * Time.deltaTime);

		

  //      Vector2 leftUp = Camera.main.ScreenToWorldPoint (new Vector2(0, 0));
		//if (Camera.main.WorldToScreenPoint(gameObject.transform.position).x <= 0){
		//	transform.position = new Vector2(leftUp.x,transform.position.y);
		//}

		//if (Camera.main.WorldToScreenPoint(gameObject.transform.position).y <= 0){
		//	transform.position = new Vector2(transform.position.x,leftUp.y);
		//}

		//Vector2 leftDown = Camera.main.ScreenToWorldPoint (new Vector2(0, Screen.height));
		//if (Camera.main.WorldToScreenPoint(gameObject.transform.position).y >= Screen.height){
		//	transform.position = new Vector2(transform.position.x,leftDown.y);
		//}
			

        /*ROTAZIONE*/

        float axisFive = Input.GetAxis (aimVerticalAxis);
		float axisFour = Input.GetAxis (aimHorizontalAxis);

		//Angolo di rotazione è l'arcotangente del valore restituito dal quinto asse, convertito in gradi

		if (axisFour != 0.0f || axisFive != 0.0f) {
			rotation = (Mathf.Atan2 (axisFive, axisFour) * Mathf.Rad2Deg);
			// Do something with the angle here.
		} 
		
		cannon.rotation = Quaternion.AngleAxis (rotation, new Vector3(0,0,1));


					/*SPARO*/

		//if (Input.GetButtonDown("LeftBumper"))
		//	Debug.Log ("Left Bumper");
		//if (Input.GetButtonDown("RightBumper"))
		//	Debug.Log ("Right Bumper");

		//if (Input.GetAxis("LeftTrigger") > 0)
		//	Debug.Log("Left Trigger");
		//if (Input.GetAxis ("RightTrigger") > 0)
		//	Debug.Log ("Right Trigger");
	
	}
}
