using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MonsterCollider")
        {
            this.transform.parent.GetComponent<Character>().takeDamage(other.transform.parent.GetComponent<Monster>().dmg);
        }
    }
}
