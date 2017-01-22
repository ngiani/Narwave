using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObj : MonoBehaviour {

	public float velocity;
	public float start, end;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, new Vector3(end, transform.localPosition.y, transform.localPosition.z), velocity*Time.deltaTime);
		if(transform.localPosition.x <= end + 1f)
		{
			transform.localPosition = new Vector3(start, transform.localPosition.y, transform.localPosition.z);
		}
	}
}
