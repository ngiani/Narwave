using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumWave : MonoBehaviour {

	public Sinus linePlayer1, linePlayer2;

	private LineRenderer line;
	private int numPoints;
	private float startPosY;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer>();
		numPoints = linePlayer1.numPoints;
		line.numPositions = numPoints;
		linePlayer2.numPoints = numPoints;
	}
	
	// Update is called once per frame
	void Update () {

		float distance = 2*Mathf.PI/numPoints;
		float sum;
		startPosY = (linePlayer1.startPosY + linePlayer2.startPosY)/2;

		for (int i = 0; i < line.numPositions; i++)
		{
			sum = linePlayer1.GetComponent<LineRenderer>().GetPosition(i).y + linePlayer2.GetComponent<LineRenderer>().GetPosition(i).y  - (linePlayer1.startPosY + linePlayer2.startPosY); 

			Debug.Log(linePlayer1.GetComponent<LineRenderer>().GetPosition(i).y + " + " + linePlayer1.GetComponent<LineRenderer>().GetPosition(i).y + " - " + (linePlayer1.startPosY + linePlayer2.startPosY) + " = " + sum);

			line.SetPosition(i, new Vector3(i*distance, sum + startPosY, 0f));
		}
	}
}
