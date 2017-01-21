using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObj : MonoBehaviour {

	public float velocity;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, new Vector3(-670f, transform.localPosition.y, transform.localPosition.z), velocity*Time.deltaTime);
		if(transform.localPosition.x <= -670f + 10f)
		{
			transform.localPosition = new Vector3(200f, transform.localPosition.y, transform.localPosition.z);
		}
	}
}
