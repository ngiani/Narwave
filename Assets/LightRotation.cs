using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour {

	public float speed;
	public Vector3 rotationAxis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, speed*Time.deltaTime);
		//transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, n);
	}
}
