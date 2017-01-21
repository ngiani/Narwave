using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementA : MonoBehaviour
{
    public float speed;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        //MOVIMENTO
        Vector2 translation = Vector2.left;
        gameObject.transform.Translate(translation * speed * Time.deltaTime);
    }
}
