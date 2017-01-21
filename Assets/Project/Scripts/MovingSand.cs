using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSand : MonoBehaviour {

	public Material material;
	public float velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		material.mainTextureOffset = Vector2.MoveTowards(material.mainTextureOffset, new Vector2(-100f, 0f), velocity*Time.deltaTime);
		if(material.mainTextureOffset.x <= -100 + 0.005f)
		{
			material.mainTextureOffset = Vector2.zero;
		}
	}
}
