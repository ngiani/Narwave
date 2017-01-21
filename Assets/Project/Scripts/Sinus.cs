using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinus : MonoBehaviour {

	public int numPoints;
	[Range(-10f,10f)]
	public float height;
	public float startPosY;

	LineRenderer line;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer>();

	}
	
	// Update is called once per frame
	void Update () {
		line.numPositions = numPoints;
		float distance = 2*Mathf.PI/numPoints;
		for (int i = 0; i < line.numPositions; i++)
		{
			line.SetPosition(i, new Vector3(i*distance, height*Mathf.Sin(i*distance) + startPosY, 0f));
		}
	}
}
